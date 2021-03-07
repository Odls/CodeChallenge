using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

internal enum E_STATE {
	Menu,
	Challenge,
}
internal class MainManager : MonoBehaviour{
	public static E_STATE state { get; private set; }
	public static MainManager instance { get; private set; }
	[SerializeField] ChallengeGroup[] challengeGroups;

	[SerializeField] ChallengeView mChallengeView;
	public static ChallengeView challengeView => instance.mChallengeView;
	[SerializeField] ChallengeMenuBox mChallengeMenuBox;
	public static ChallengeMenuBox challengeMenuBox => instance.mChallengeMenuBox;
	[SerializeField] ChallengeResultBox mChallengeResultBox;
	public static ChallengeResultBox challengeResultBox => instance.mChallengeResultBox;

	private void Awake() {
		instance = this;
		int _groupIndex = 0;
		foreach (var _group in challengeGroups) {
			_group.Init(_groupIndex);
			_groupIndex++;
		}

		mChallengeMenuBox.Init(challengeGroups);
	}
	private void Start() {

		string _lastChallengeName = PlayerPrefs.GetString("nowChallenge");
		ChallengeGroup _lastGroup = null;
		ChallengeBase _lastChallenge = null;
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

	[SerializeField] Animator animator;
	public static void ToMenu(bool p_Immediately = false) {
		state = E_STATE.Menu;
		instance.animator.Play("ToMenu", 0, p_Immediately?1:0);
		PlayerPrefs.SetString("nowChallenge", "");
	}
	public static void ToChallenge(ChallengeGroup p_group, ChallengeBase p_challenge, bool p_Immediately = false) {
		state = E_STATE.Challenge;
		challengeView.Show(p_group, p_challenge);
		instance.RunChallenge(p_challenge);
		instance.animator.Play("ToChallenge", 0, p_Immediately ? 1 : 0);
	}
	public static void EditChallenge(ChallengeBase p_challenge) {
		var _script = MonoScript.FromScriptableObject(p_challenge);
		AssetDatabase.OpenAsset(_script);
		PlayerPrefs.SetString("nowChallenge", p_challenge.title);
		EditorApplication.isPlaying = false;
	}

	WaitForSeconds runTestDelay = new WaitForSeconds(0.5f);
	Coroutine runChallengeCoroutine;
	public void RunChallenge(ChallengeBase p_challenge) {
		if (runChallengeCoroutine != null) { StopCoroutine(runChallengeCoroutine); }
		runChallengeCoroutine = StartCoroutine(IeRunChallenge(p_challenge));
	}
	IEnumerator IeRunChallenge(ChallengeBase p_challenge) {
		challengeResultBox.Talk("執行中...");

		int _testCount = p_challenge.testCount;
		bool _allSuccess = true;
		for(int f=0; f<_testCount; f++) {
			yield return runTestDelay;
			var _test = p_challenge.GetTest(f);
			bool _success = false;
			try {
				_success = p_challenge.RunTest(f);
				if (!_success) {
					challengeResultBox.Talk("執行完成！\n但未輸出正確的結果");
				}
			} catch (NotDoException _) {
				challengeResultBox.Talk("尚未進行！\n點擊 [編輯] 按鈕開始挑戰");
				yield break;
			} catch (System.Exception ex) {
				challengeResultBox.Talk("執行中發生例外狀況！\n根據Console視窗中的訊息除錯");
				Debug.LogException(ex);
			}
			if (!_success) {
				_allSuccess = false;
				break;
			}
		}
		if (_allSuccess) {
			challengeResultBox.Talk("執行結果正確！");
		}
	}
}
