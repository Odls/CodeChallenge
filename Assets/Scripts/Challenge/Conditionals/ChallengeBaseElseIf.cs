using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseElseIf : ChallengeBase {
	public ChallengeBaseElseIf() {
		tests = new TestItem[] {
			new TestItem(
				"42 + 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",		fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",		fieldValue = 6},
					new TestIntField{showFormat="p_operator = {0}",	fieldValue = 0}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 48}
				}
			),
			new TestItem(
				"42 - 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",		 fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",		 fieldValue = 6},
					new TestIntField{showFormat="p_operator = {0}",  fieldValue = 1}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 36}
				}
			),
			new TestItem(
				"42 * 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",		 fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",		 fieldValue = 6},
					new TestIntField{showFormat="p_operator = {0}",  fieldValue = 2}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 252}
				}
			),
			new TestItem(
				"42 / 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",		 fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",		 fieldValue = 6},
					new TestIntField{showFormat="p_operator = {0}",  fieldValue = 3}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 7}
				}
			),
			new TestItem(
				"42 ? 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",		 fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",		 fieldValue = 6},
					new TestIntField{showFormat="p_operator = {0}",  fieldValue = 1000}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 0}
				}
			),
			new TestItem(
				"40 + 2",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",		 fieldValue = 40},
					new TestIntField{showFormat="p_b = {0}",		 fieldValue = 2},
					new TestIntField{showFormat="p_operator = {0}",  fieldValue = 0}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 42}
				}
			),
			new TestItem(
				"7 * 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",		 fieldValue = 7},
					new TestIntField{showFormat="p_b = {0}",		 fieldValue = 6},
					new TestIntField{showFormat="p_operator = {0}",  fieldValue = 2}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 42}
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int, int, int>(p_test, ElseIfConditional);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void ElseIfConditional(int p_a, int p_b, int p_operator) { throw new NotDoException(); }
}
