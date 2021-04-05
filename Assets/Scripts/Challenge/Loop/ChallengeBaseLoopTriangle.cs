using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseLoopTriangle : ChallengeBase {
	public ChallengeBaseLoopTriangle() {
		tests = new TestItem[] {
			new TestItem(
				"1 層三角",
				new TestField[] {
					new TestIntField{	showFormat="p_count = {0}",	fieldValue = 1}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "◣"}
				}
			),
			new TestItem(
				"2 層三角",
				new TestField[] {
					new TestIntField{   showFormat="p_count = {0}", fieldValue = 2}
				},
				new TestField[] {
					new TestStringField{    fieldValue = "◣"},
					new TestStringField{    fieldValue = "■◣"}
				}
			),
			new TestItem(
				"3 層三角",
				new TestField[] {
					new TestIntField{   showFormat="p_count = {0}", fieldValue = 3}
				},
				new TestField[] {
					new TestStringField{    fieldValue = "◣"},
					new TestStringField{    fieldValue = "■◣"},
					new TestStringField{    fieldValue = "■■◣"}
				}
			),
			new TestItem(
				"7 層三角",
				new TestField[] {
					new TestIntField{   showFormat="p_count = {0}", fieldValue = 7}
				},
				new TestField[] {
					new TestStringField{    fieldValue = "◣"},
					new TestStringField{    fieldValue = "■◣"},
					new TestStringField{    fieldValue = "■■◣"},
					new TestStringField{    fieldValue = "■■■◣"},
					new TestStringField{    fieldValue = "■■■■◣"},
					new TestStringField{    fieldValue = "■■■■■◣"},
					new TestStringField{    fieldValue = "■■■■■■◣"}
				}
			),
			new TestItem(
				"沒有三角",
				new TestField[] {
					new TestIntField{   showFormat="p_count = {0}", fieldValue = 0}
				},
				new TestField[] {
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int>(p_test, LoopTriangle);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void LoopTriangle(int p_count) { throw new NotDoException(); }
}
