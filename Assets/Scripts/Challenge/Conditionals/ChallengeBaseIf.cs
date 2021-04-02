using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseIf : ChallengeBase {
	public ChallengeBaseIf() {
		tests = new TestItem[] {
			new TestItem(
				"判斷 42",
				new TestField[] { new TestIntField{ fieldValue = 42} },
				new TestField[] { new TestStringField{ fieldValue = "正數" } }
			),
			new TestItem(
				"判斷 0",
				new TestField[] { new TestIntField{ fieldValue = 0} },
				new TestField[] { new TestStringField{ fieldValue = "正數" } }
			),
			new TestItem(
				"判斷 -1",
				new TestField[] { new TestIntField{ fieldValue = -1} },
				new TestField[] { new TestStringField{ fieldValue = "負數" } }
			),
			new TestItem(
				"判斷 777",
				new TestField[] { new TestIntField{ fieldValue =  777} },
				new TestField[] { new TestStringField{ fieldValue = "正數" } }
			),
			new TestItem(
				"判斷 -999",
				new TestField[] { new TestIntField{ fieldValue = -999} },
				new TestField[] { new TestStringField{ fieldValue = "負數" } }
			),
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int>(p_test, IfConditional);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void IfConditional(int p_value) { throw new NotDoException(); }
}
