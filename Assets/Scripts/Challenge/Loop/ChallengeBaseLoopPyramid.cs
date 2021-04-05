using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseLoopPyramid : ChallengeBase {
	public ChallengeBaseLoopPyramid() {
		tests = new TestItem[] {
			new TestItem(
				"1 層金字塔",
				new TestField[] {
					new TestIntField{   showFormat="p_count = {0}", fieldValue = 1}
				},
				new TestField[] {
					new TestStringField{    fieldValue = "▲"}
				}
			),
			new TestItem(
				"2 層金字塔",
				new TestField[] {
					new TestIntField{   showFormat="p_count = {0}", fieldValue = 2}
				},
				new TestField[] {
					new TestStringField{    fieldValue = "　▲"},
					new TestStringField{    fieldValue = "◢■◣"}
				}
			),
			new TestItem(
				"3 層金字塔",
				new TestField[] {
					new TestIntField{   showFormat="p_count = {0}", fieldValue = 3}
				},
				new TestField[] {
					new TestStringField{    fieldValue = "　　▲"},
					new TestStringField{    fieldValue = "　◢■◣"},
					new TestStringField{    fieldValue = "◢■■■◣"}
				}
			),
			new TestItem(
				"7 層金字塔",
				new TestField[] {
					new TestIntField{   showFormat="p_count = {0}", fieldValue = 7}
				},
				new TestField[] {
					new TestStringField{    fieldValue = "　　　　　　▲"},
					new TestStringField{    fieldValue = "　　　　　◢■◣"},
					new TestStringField{    fieldValue = "　　　　◢■■■◣"},
					new TestStringField{    fieldValue = "　　　◢■■■■■◣"},
					new TestStringField{    fieldValue = "　　◢■■■■■■■◣"},
					new TestStringField{    fieldValue = "　◢■■■■■■■■■◣"},
					new TestStringField{    fieldValue = "◢■■■■■■■■■■■◣"}
				}
			),
			new TestItem(
				"沒有金字塔",
				new TestField[] {
					new TestIntField{   showFormat="p_count = {0}", fieldValue = 0}
				},
				new TestField[] {
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int>(p_test, LoopPyramid);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void LoopPyramid(int p_count) { throw new NotDoException(); }
}
