using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseLogicalOperator : ChallengeBase {
	public ChallengeBaseLogicalOperator() {
		tests = new TestItem[] {
			new TestItem(
				"Up",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(60, 200)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(40, 50)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(100, 130)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = false}
				}
			),
			new TestItem(
				"Left",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(10, 120)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(40, 50)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(100, 150)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = false}
				}
			),
			new TestItem(
				"Down",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(10, 120)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(-40, 150)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(100, 30)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = false}
				}
			),
			new TestItem(
				"Right",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(10, 120)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(-120, 50)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(100, 150)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = false}
				}
			),
			new TestItem(
				"In",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(30, -20)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(10, -50)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(100, 150)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = true}
				}
			),

			new TestItem(
				"In",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(-10, 15)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(-30, -20)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(150, 50)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = true}
				}
			),
			new TestItem(
				"Left Up",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(-30, 30)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(-10, -60)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(60, 80)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = false}
				}
			),
			new TestItem(
				"Right Up",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(60, 30)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(-10, -60)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(60, 80)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = false}
				}
			),

			new TestItem(
				"Left Down",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(-20, -10)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(-10, 0)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(100, 30)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = false}
				}
			),

			new TestItem(
				"Right Down",
				new TestField[] {
					new TestV2Field{    showFormat="p_point = {0}",     fieldValue = new Vector2(100, -10)},
					new TestV2Field{    showFormat="p_rectPos = {0}",   fieldValue = new Vector2(-10, 0)},
					new TestV2Field{    showFormat="p_rectSize = {0}",  fieldValue = new Vector2(100, 30)}
				},
				new TestField[] {
					new TestBoolField{ fieldValue = false}
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<Vector2, Vector2, Vector2>(p_test, LogicalOperator);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void LogicalOperator(Vector2 p_point, Vector2 p_rectPos, Vector2 p_rectSize) { throw new NotDoException(); }
}
