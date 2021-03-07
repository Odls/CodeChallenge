using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal class ChallengeResultBox : MonoBehaviour{
	[SerializeField] Text talk;
	[SerializeField] ResultView resultViewPrefab;
	public void Talk(string p_talk) {
		talk.text = "<i><b>歐德斯：</b></i>" + p_talk;
	}
	public void ShowResult(TestItemBase p_test, string p_challengerResult = "") {

	}
	public void ClearResult() {

	}
}
