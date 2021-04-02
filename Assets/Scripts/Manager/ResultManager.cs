using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_RESULT_STATE {
	NotDo,
	Success,
	Fail,
	Exception
}

public static class Result {
	internal static readonly List<TestField> resultFields = new List<TestField>();

	internal static bool CheckSame(TestField[] targetFields) {
		if(resultFields.Count != targetFields.Length) {
			return false;
		}
		for(int f=0; f< targetFields.Length; f++) {
			if (!resultFields[f].CheckSame(targetFields[f])) {
				return false;
			}
		}
		return true;
	}

	public static void Print(int p_int) {
		resultFields.Add(new TestIntField { fieldValue = p_int });
	}
	public static void Print(float p_float) {
		if (p_float % 1 == 0) {
			resultFields.Add(new TestFloatField { showFormat="{0:0.0}", fieldValue = p_float });
		} else {
			resultFields.Add(new TestFloatField { fieldValue = p_float });
		}
	}
	public static void Print(bool p_bool) {
		resultFields.Add(new TestBoolField { fieldValue = p_bool });
	}
	public static void Print(string p_string) {
		resultFields.Add(new TestStringField { fieldValue = p_string });
	}
}
