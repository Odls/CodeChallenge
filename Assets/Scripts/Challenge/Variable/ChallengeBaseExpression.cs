using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseExpression : ChallengeBase {
	public ChallengeBaseExpression() {
		tests = new TestItem[] {
			new TestItem(
				"y(100) -> [y = x / 2 + 1]",
				new TestField[] {
					new TestIntField{	showFormat="p_a = {0}",	fieldValue = 2},
					new TestFloatField{	showFormat="p_b = {0}",	fieldValue = 1},
					new TestIntField{	showFormat="p_x = {0}",	fieldValue = 100}
				},
				new TestField[] {
					new TestFloatField{ fieldValue = 51}
				}
			),
			new TestItem(
				"y(100) -> [y = x / 2 + 1.5]",
				new TestField[] {
					new TestIntField{	showFormat="p_a = {0}",	fieldValue = 2},
					new TestFloatField{	showFormat="p_b = {0}",	fieldValue = 1.5f},
					new TestIntField{   showFormat="p_x = {0}", fieldValue = 100}
				},
				new TestField[] {
					new TestFloatField{ fieldValue = 51.5f}
				}
			),
			new TestItem(
				"y(10) -> [y = x / 10 + 0.1f]",
				new TestField[] {
					new TestIntField{   showFormat="p_a = {0}", fieldValue = 10},
					new TestFloatField{	showFormat="p_b = {0}",	fieldValue = 0.1f},
					new TestIntField{	showFormat="p_x = {0}",	fieldValue = 10}
				},
				new TestField[] {
					new TestFloatField{ fieldValue = 1.1f}
				}
			),
			new TestItem(
				"y(10) -> [y = x / 20 + 0.1f]",
				new TestField[] {
					new TestIntField{   showFormat="p_a = {0}", fieldValue = 20},
					new TestFloatField{	showFormat="p_b = {0}",	fieldValue = 0.1f},
					new TestIntField{	showFormat="p_x = {0}",	fieldValue = 10}
				},
				new TestField[] {
					new TestFloatField{ fieldValue = 0.6f}
				}
			),
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int, float, int>(p_test, Expression);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void Expression(int p_a, float p_b, int p_x) { throw new NotDoException(); }
}
