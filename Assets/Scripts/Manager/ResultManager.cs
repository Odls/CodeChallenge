using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_RESULT_STATE {
	NotDo,
	Success,
	Fail,
	Exception
}

public class Result : MonoBehaviour {
	public static Result instance { get; private set; }
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
	public static void Print(bool p_bool) {
		resultFields.Add(new TestBoolField { fieldValue = p_bool });
	}
	public static void Print(string p_string) {
		resultFields.Add(new TestStringField { fieldValue = p_string });
	}
}
