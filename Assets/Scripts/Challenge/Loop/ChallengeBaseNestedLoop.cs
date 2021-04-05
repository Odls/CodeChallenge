using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseNestedLoop : ChallengeBase {
	public ChallengeBaseNestedLoop() {
		tests = new TestItem[] {
			new TestItem(
				"Multiplication Table",
				new TestField[] {},
				new TestField[] {
					new TestStringField{	fieldValue ="2 × 1 = 2"},
					new TestStringField{	fieldValue ="2 × 2 = 4"},
					new TestStringField{	fieldValue ="2 × 3 = 6"},
					new TestStringField{	fieldValue ="2 × 4 = 8"},
					new TestStringField{	fieldValue ="2 × 5 = 10"},
					new TestStringField{	fieldValue ="2 × 6 = 12"},
					new TestStringField{	fieldValue ="2 × 7 = 14"},
					new TestStringField{	fieldValue ="2 × 8 = 16"},
					new TestStringField{	fieldValue ="2 × 9 = 18"},
					new TestStringField{	fieldValue ="3 × 1 = 3"},
					new TestStringField{	fieldValue ="3 × 2 = 6"},
					new TestStringField{	fieldValue ="3 × 3 = 9"},
					new TestStringField{	fieldValue ="3 × 4 = 12"},
					new TestStringField{	fieldValue ="3 × 5 = 15"},
					new TestStringField{	fieldValue ="3 × 6 = 18"},
					new TestStringField{	fieldValue ="3 × 7 = 21"},
					new TestStringField{	fieldValue ="3 × 8 = 24"},
					new TestStringField{	fieldValue ="3 × 9 = 27"},
					new TestStringField{	fieldValue ="4 × 1 = 4"},
					new TestStringField{	fieldValue ="4 × 2 = 8"},
					new TestStringField{	fieldValue ="4 × 3 = 12"},
					new TestStringField{	fieldValue ="4 × 4 = 16"},
					new TestStringField{	fieldValue ="4 × 5 = 20"},
					new TestStringField{	fieldValue ="4 × 6 = 24"},
					new TestStringField{	fieldValue ="4 × 7 = 28"},
					new TestStringField{	fieldValue ="4 × 8 = 32"},
					new TestStringField{	fieldValue ="4 × 9 = 36"},
					new TestStringField{	fieldValue ="5 × 1 = 5"},
					new TestStringField{	fieldValue ="5 × 2 = 10"},
					new TestStringField{	fieldValue ="5 × 3 = 15"},
					new TestStringField{	fieldValue ="5 × 4 = 20"},
					new TestStringField{	fieldValue ="5 × 5 = 25"},
					new TestStringField{	fieldValue ="5 × 6 = 30"},
					new TestStringField{	fieldValue ="5 × 7 = 35"},
					new TestStringField{	fieldValue ="5 × 8 = 40"},
					new TestStringField{	fieldValue ="5 × 9 = 45"},
					new TestStringField{	fieldValue ="6 × 1 = 6"},
					new TestStringField{	fieldValue ="6 × 2 = 12"},
					new TestStringField{	fieldValue ="6 × 3 = 18"},
					new TestStringField{	fieldValue ="6 × 4 = 24"},
					new TestStringField{	fieldValue ="6 × 5 = 30"},
					new TestStringField{	fieldValue ="6 × 6 = 36"},
					new TestStringField{	fieldValue ="6 × 7 = 42"},
					new TestStringField{	fieldValue ="6 × 8 = 48"},
					new TestStringField{	fieldValue ="6 × 9 = 54"},
					new TestStringField{	fieldValue ="7 × 1 = 7"},
					new TestStringField{	fieldValue ="7 × 2 = 14"},
					new TestStringField{	fieldValue ="7 × 3 = 21"},
					new TestStringField{	fieldValue ="7 × 4 = 28"},
					new TestStringField{	fieldValue ="7 × 5 = 35"},
					new TestStringField{	fieldValue ="7 × 6 = 42"},
					new TestStringField{	fieldValue ="7 × 7 = 49"},
					new TestStringField{	fieldValue ="7 × 8 = 56"},
					new TestStringField{	fieldValue ="7 × 9 = 63"},
					new TestStringField{	fieldValue ="8 × 1 = 8"},
					new TestStringField{	fieldValue ="8 × 2 = 16"},
					new TestStringField{	fieldValue ="8 × 3 = 24"},
					new TestStringField{	fieldValue ="8 × 4 = 32"},
					new TestStringField{	fieldValue ="8 × 5 = 40"},
					new TestStringField{	fieldValue ="8 × 6 = 48"},
					new TestStringField{	fieldValue ="8 × 7 = 56"},
					new TestStringField{	fieldValue ="8 × 8 = 64"},
					new TestStringField{	fieldValue ="8 × 9 = 72"},
					new TestStringField{	fieldValue ="9 × 1 = 9"},
					new TestStringField{	fieldValue ="9 × 2 = 18"},
					new TestStringField{	fieldValue ="9 × 3 = 27"},
					new TestStringField{	fieldValue ="9 × 4 = 36"},
					new TestStringField{	fieldValue ="9 × 5 = 45"},
					new TestStringField{	fieldValue ="9 × 6 = 54"},
					new TestStringField{	fieldValue ="9 × 7 = 63"},
					new TestStringField{	fieldValue ="9 × 8 = 72"},
					new TestStringField{	fieldValue ="9 × 9 = 81"}
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		NestedLoop();
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void NestedLoop() { throw new NotDoException(); }
}
