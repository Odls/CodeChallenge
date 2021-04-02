using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeBaseTypeConversion : ChallengeBase {
	public ChallengeBaseTypeConversion() {
		tests = new TestItem[] {
			new TestItem(
				"轉換 42 和 3.14159",
				new TestField[] {
					new TestIntField{ showFormat="p_int = {0}", fieldValue = 42},
					new TestFloatField{ showFormat="p_float = {0}", fieldValue = 3.14159f}
				},
				new TestField[] {
					new TestFloatField{ showFormat="{0:0.0}", fieldValue = 42.0f},
					new TestIntField{ fieldValue = 3}
				}
			),
			new TestItem(
				"轉換 100 和 99.99",
				new TestField[] {
					new TestIntField{ showFormat="p_int = {0}", fieldValue = 100},
					new TestFloatField{ showFormat="p_float = {0}", fieldValue = 99.99f}
				},
				new TestField[] {
					new TestFloatField{ showFormat="{0:0.0}", fieldValue = 100.0f},
					new TestIntField{ fieldValue = 99}
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int, float>(p_test, TypeConversion);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void TypeConversion(int p_int, float p_float) { throw new NotDoException(); }
}
