using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal class ChallengeResultBox : MonoBehaviour{
	[SerializeField] Text talk;
	[SerializeField] ResultView resultViewPrefab;
	[SerializeField] ScrollRect scrollRect;
	[SerializeField] float scrollSpeed = 5000f;
	public void Talk(string p_talk) {
		talk.text = "<i><b>歐德斯：</b></i>" + p_talk;
	}
	List<ResultView> resultViews = new List<ResultView>();
	public void ShowResult(TestItem p_test, List<TestField> p_challengerResults, E_RESULT_STATE p_resultState) {
		var _resultView = Instantiate(resultViewPrefab, scrollRect.content.transform);
		_resultView.Init(p_test, p_challengerResults, p_resultState);
		resultViews.Add(_resultView);
		ToBottom();
	}
	public void ClearResult() {
		foreach (var _resultView in resultViews) {
			Destroy(_resultView.gameObject);
		}
		resultViews.Clear();
	}

	public void ToBottom() {
		StartCoroutine(IeToBottom());
	}
	IEnumerator IeToBottom() {
		MainManager.UpdateTransformLayout(scrollRect.transform);
		yield return null;
		while(scrollRect.verticalNormalizedPosition >= 0.0001f) {
			scrollRect.verticalNormalizedPosition = Mathf.MoveTowards(scrollRect.verticalNormalizedPosition, 0, Time.deltaTime * scrollSpeed / scrollRect.content.sizeDelta.y);
			yield return null;
		}
		scrollRect.verticalNormalizedPosition = 0;
	}
}
