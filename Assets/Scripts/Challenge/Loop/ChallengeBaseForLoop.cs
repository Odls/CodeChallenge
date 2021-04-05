using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseForLoop : ChallengeBase {
	public ChallengeBaseForLoop() {
		tests = new TestItem[] {
			new TestItem(
				"0~2, 3 Number",
				new TestField[] {
					new TestIntField{   showFormat="p_startNumber = {0}",   fieldValue = 0},
					new TestIntField{   showFormat="p_numberCount = {0}",   fieldValue = 3},
				},
				new TestField[] {
					new TestIntField{   fieldValue = 0},
					new TestIntField{   fieldValue = 1},
					new TestIntField{   fieldValue = 2}
				}
			),
			new TestItem(
				"0 Number",
				new TestField[] {
					new TestIntField{   showFormat="p_startNumber = {0}",   fieldValue = 100},
					new TestIntField{   showFormat="p_numberCount = {0}",   fieldValue = 0}
				},
				new TestField[] {}
			),
			new TestItem(
				"5~14, 10 Number",
				new TestField[] {
					new TestIntField{   showFormat="p_startNumber = {0}",   fieldValue = 5},
					new TestIntField{   showFormat="p_numberCount = {0}",   fieldValue = 10}
				},
				new TestField[] {
					new TestIntField{   fieldValue = 5},
					new TestIntField{   fieldValue = 6},
					new TestIntField{   fieldValue = 7},
					new TestIntField{   fieldValue = 8},
					new TestIntField{   fieldValue = 9},
					new TestIntField{   fieldValue = 10},
					new TestIntField{   fieldValue = 11},
					new TestIntField{   fieldValue = 12},
					new TestIntField{   fieldValue = 13},
					new TestIntField{   fieldValue = 14}
				}
			),
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int, int>(p_test, ForLoop);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void ForLoop(int p_startNumber, int p_numberCount) { throw new NotDoException(); }
}
