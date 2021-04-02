using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseSwap : ChallengeBase {
	public ChallengeBaseSwap() {
		tests = new TestItem[] {
			new TestItem(
				"交換 42 和 42",
				new TestField[] {
					new TestIntField{ showFormat="p_a = {0}", fieldValue = 42},
					new TestIntField{ showFormat="p_b = {0}", fieldValue = 42}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 42},
					new TestIntField{ fieldValue = 42}
				}
			),
			new TestItem(
				"交換 3 和 5",
				new TestField[] {
					new TestIntField{ showFormat="p_a = {0}", fieldValue = 3},
					new TestIntField{ showFormat="p_b = {0}", fieldValue = 5}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 5},
					new TestIntField{ fieldValue = 3}
				}
			),
			new TestItem(
				"交換 100 和 0",
				new TestField[] {
					new TestIntField{ showFormat="p_a = {0}", fieldValue = 100},
					new TestIntField{ showFormat="p_b = {0}", fieldValue = 0}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 0},
					new TestIntField{ fieldValue = 100}
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int, int>(p_test, Swap);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void Swap(int p_a, int p_b) { throw new NotDoException(); }
}
