using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

internal enum E_STATE {
	Menu,
	Challenge,
}
internal class MainManager : MonoBehaviour{
	public static E_STATE state { get; private set; }
	public static MainManager instance { get; private set; }
	[SerializeField] Sprite[] marks;

	[SerializeField] ChallengeGroup[] challengeGroups;
	[SerializeField] ChallengeView mChallengeView;
	public static ChallengeView challengeView => instance.mChallengeView;
	[SerializeField] ChallengeMenuBox mChallengeMenuBox;
	public static ChallengeMenuBox challengeMenuBox => instance.mChallengeMenuBox;
	[SerializeField] ChallengeResultBox mChallengeResultBox;
	public static ChallengeResultBox challengeResultBox => instance.mChallengeResultBox;

	public static Dictionary<string, ChallengeBut> challengeButDict = new Dictionary<string, ChallengeBut>();

	private void Awake() {
		instance = this;
		int _groupIndex = 0;
		foreach (var _group in challengeGroups) {
			_group.Init(_groupIndex);
			_groupIndex++;
		}

		challengeMenuBox.Init(challengeGroups);
	}
	private void Start() {

		string _lastChallengeName = PlayerPrefs.GetString("nowChallenge");
		ChallengeGroup _lastGroup = null;
		ChallengeData _lastChallenge = null;
		foreach (var _group in challengeGroups) {
			foreach (var _challenge in _group.challenges) {
				if (_challenge.title == _lastChallengeName) {
					_lastGroup = _group;
					_lastChallenge = _challenge;
					break;
				}
			}
		}

		if (_lastChallenge != null) {
			ToChallenge(_lastGroup, _lastChallenge, true);
		} else {
			ToMenu(true);
		}
	}

	internal static Sprite GetMark(E_RESULT_STATE p_resultState) {
		return instance.marks[(int)p_resultState];
	}

	[SerializeField] Animator animator;
	public static void ToMenu(bool p_Immediately = false) {
		state = E_STATE.Menu;
		instance.animator.Play("ToMenu", 0, p_Immediately?1:0);
		PlayerPrefs.SetString("nowChallenge", "");
	}
	public static void ToChallenge(ChallengeGroup p_group, ChallengeData p_challenge, bool p_Immediately = false) {
		state = E_STATE.Challenge;
		challengeResultBox.ClearResult();
		challengeView.Show(p_group, p_challenge);
		instance.RunChallenge(p_challenge);
		PlayerPrefs.SetString("nowChallenge", p_challenge.title);
		instance.animator.Play("ToChallenge", 0, p_Immediately ? 1 : 0);
	}
	public static void EditChallenge(ChallengeData p_challenge) {
		var _script = MonoScript.FromScriptableObject(p_challenge);
		AssetDatabase.OpenAsset(_script);
		EditorApplication.isPlaying = false;
	}

	WaitForSeconds startTestDelay = new WaitForSeconds(0.6f);
	WaitForSeconds runTestDelay = new WaitForSeconds(0.4f);
	Coroutine runChallengeCoroutine;
	void RunChallenge(ChallengeData p_challenge) {
		if (runChallengeCoroutine != null) { StopCoroutine(runChallengeCoroutine); }
		runChallengeCoroutine = StartCoroutine(IeRunChallenge(p_challenge));
	}
	IEnumerator IeRunChallenge(ChallengeData p_challenge) {
		challengeResultBox.Talk("<color=#808080>執行中...</color>");
		yield return startTestDelay;
		int _testCount = p_challenge.testCount;
		for(int f=0; f<_testCount; f++) {
			yield return runTestDelay;
			var _test = p_challenge.GetTest(f);
			E_RESULT_STATE _state;
			Result.resultFields.Clear();
			try {
				_state = p_challenge.RunTest(f) ? E_RESULT_STATE.Success : E_RESULT_STATE.Fail;
			} catch (NotDoException _) {
				_state = E_RESULT_STATE.NotDo;
			} catch (System.Exception ex) {
				_state = E_RESULT_STATE.Exception;
				Debug.LogException(ex);
			}
			switch (_state) {
			case E_RESULT_STATE.NotDo:
				OnChallengeDone(p_challenge, _state, "尚未進行！\n點擊 [編輯] 按鈕開始挑戰");
				yield break;
				break;
			case E_RESULT_STATE.Success:
				challengeResultBox.ShowResult(_test, Result.resultFields, _state);
				break;
			case E_RESULT_STATE.Fail:
				challengeResultBox.ShowResult(_test, Result.resultFields, _state);
				OnChallengeDone(p_challenge, _state, "執行完成！\n但<color=#ff0000>輸出結果不正確</color>，點擊 [編輯] 按鈕修改");
				yield break;
				break;
			case E_RESULT_STATE.Exception:
				challengeResultBox.ShowResult(_test, Result.resultFields, _state);
				OnChallengeDone(p_challenge, _state, "執行中<color=#ffff00>發生例外狀況</color>！\n根據Console視窗中的訊息除錯");
				yield break;
				break;
			}
		}
		OnChallengeDone(p_challenge, E_RESULT_STATE.Success, "<color=#00ff00>執行結果正確！</color>");
	}
	public static void OnChallengeDone(ChallengeData p_challenge, E_RESULT_STATE p_state, string p_talk) {
		challengeResultBox.Talk(p_talk);
		p_challenge.state = p_state;
		challengeButDict[p_challenge.name].RefreahState();
		PlayerPrefs.SetInt(p_challenge.name, (int)p_state);
	}
	public static void UpdateTransformLayout(Transform p_transform) {
		Canvas.ForceUpdateCanvases();
		UpdateLayout(p_transform);
	}
	static void UpdateLayout(Transform p_transform) {
		for (int f = 0; f < p_transform.childCount; f++) {
			UpdateLayout(p_transform.GetChild(f));
		}

		foreach (var _layout in p_transform.GetComponents<LayoutGroup>()) {
			_layout.CalculateLayoutInputVertical();
			_layout.CalculateLayoutInputHorizontal();
		}
		foreach (var _fitter in p_transform.GetComponents<ContentSizeFitter>()) {
			_fitter.SetLayoutVertical();
			_fitter.SetLayoutHorizontal();
		}
	}
}
