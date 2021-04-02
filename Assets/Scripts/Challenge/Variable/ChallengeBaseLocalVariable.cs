using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseLocalVariable : ChallengeBase {
	public ChallengeBaseLocalVariable() {
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
					new TestIntField{ fieldValue = 5}
				}
			),
			new TestItem(
				"加10",
				new TestField[]{
					new TestIntField{showFormat="p_addNumber = {0}",  fieldValue = 10}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 10}
				}
			),
			new TestItem(
				"加0",
				new TestField[]{
					new TestIntField{showFormat="p_addNumber = {0}",  fieldValue = 0}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 0}
				}
			),
			new TestItem(
				"加1000",
				new TestField[]{
					new TestIntField{showFormat="p_addNumber = {0}",  fieldValue = 1000}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 1000}
				}
			),
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int>(p_test, LocalVariable);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void LocalVariable(int p_number) { throw new NotDoException(); }
}
