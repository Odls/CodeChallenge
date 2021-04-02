using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseHelloVariable : ChallengeBase {
	public ChallengeBaseHelloVariable() {
		tests = new TestItem[] {
			new TestItem(
				"變數宣告",
				new TestField[0],
				new TestField[] {
					new TestIntField{ fieldValue = 42},
					new TestFloatField{ fieldValue = 3.14159f},
					new TestBoolField{ fieldValue = true},
					new TestStringField{ fieldValue = "Hello Variable!"}
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		HelloVariable();
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void HelloVariable() { throw new NotDoException(); }
}
