using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseSumVariable : ChallengeBase {
	public ChallengeBaseSumVariable() {
		tests = new TestItem[] {
			new TestItem(
				"加1",
				new TestField[]{
					new TestIntField{showFormat="p_addNumber = {0}", fieldValue = 1}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 1}
				}
			),
			new TestItem(
				"加5",
				new TestField[]{
					new TestIntField{showFormat="p_addNumber = {0}",  fieldValue = 5}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 6}
				}
			),
			new TestItem(
				"加10",
				new TestField[]{
					new TestIntField{showFormat="p_addNumber = {0}",  fieldValue = 10}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 16}
				}
			),
			new TestItem(
				"加0",
				new TestField[]{
					new TestIntField{showFormat="p_addNumber = {0}",  fieldValue = 0}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 16}
				}
			),
			new TestItem(
				"加1000",
				new TestField[]{
					new TestIntField{showFormat="p_addNumber = {0}",  fieldValue = 1000}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 1016}
				}
			),
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int>(p_test, SumVariable);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void SumVariable(int p_number) { throw new NotDoException(); }
}
