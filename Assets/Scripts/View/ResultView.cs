using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal class ResultView : MonoBehaviour{
	[SerializeField] Image mark;
	[SerializeField] Text title;
	[SerializeField] Text input;
	[SerializeField] Text expectedResult;
	[SerializeField] Text challengerResult;

	public void Init(TestItemBase p_test, string p_challengerResult = "") {
		title.text = p_test.showText;

		string _temp = p_test.inputText;
		input.text = (_temp!="") ? _temp : "(無)";

		_temp = p_test.expectedResult;
		expectedResult.text = (_temp != "") ? _temp : "(無)";

		_temp = p_challengerResult;
		challengerResult.text = (_temp != "") ? _temp : "(無)";
	}
}
