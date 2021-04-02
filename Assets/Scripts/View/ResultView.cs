using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal class ResultView : MonoBehaviour{
	[SerializeField] Image mark;
	[SerializeField] Text title;
	[SerializeField] Text input;
	[SerializeField] GameObject expectedTop;
	[SerializeField] Text expectedResult;
	[SerializeField] Text challengerResult;

	public void Init(TestItem p_test, List<TestField> p_challengerResults, E_RESULT_STATE p_resultState) {
		title.text = p_test.showText;

		string _temp = p_test.inputText;
		input.text = (_temp!="") ? _temp : "(無)";

		_temp = p_test.expectedResultText;
		expectedResult.text = (_temp != "") ? _temp : "(無)";
		expectedTop.SetActive(p_resultState == E_RESULT_STATE.Fail);

		_temp = TestField.FieldsToString(p_challengerResults);
		challengerResult.text = (_temp != "") ? _temp : "(無)";


		mark.sprite = MainManager.GetMark(p_resultState);
	}
}
