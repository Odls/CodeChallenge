using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseDoWhile : ChallengeBase {
	public ChallengeBaseDoWhile() {
		tests = new TestItem[] {
			new TestItem(
				"野生的史萊姆出現了",
				new TestField[] {
					new TestIntField{		showFormat="p_enemyHp = {0}",	fieldValue = 1}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "傷害溢出 9"},
				}
			),
			new TestItem(
				"野生的哥布林出現了",
				new TestField[] {
					new TestIntField{       showFormat="p_enemyHp = {0}",   fieldValue = 15}
				},
				new TestField[] {
					new TestStringField{    fieldValue = "攻擊"},
					new TestStringField{    fieldValue = "攻擊"},
					new TestStringField{    fieldValue = "傷害溢出 5"},
				}
			),
			new TestItem(
				"路邊的石頭出現了",
				new TestField[] {
					new TestIntField{		showFormat="p_enemyHp = {0}",	fieldValue = 0}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "傷害溢出 10"},
				}
			),
			new TestItem(
				"野生的半獸人出現了",
				new TestField[] {
					new TestIntField{		showFormat="p_enemyHp = {0}",	fieldValue = 30}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "完美擊敗"},
				}
			),
			new TestItem(
				"普通的路人出現了",
				new TestField[] {
					new TestIntField{		showFormat="p_enemyHp = {0}",	fieldValue = 12}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "傷害溢出 8"},
				}
			),
			new TestItem(
				"路人變成屍體了",
				new TestField[] {
					new TestIntField{		showFormat="p_enemyHp = {0}",   fieldValue = -8}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "傷害溢出 10"},
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int>(p_test, DoWhileAttack);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void DoWhileAttack(int p_enemyHp) { throw new NotDoException(); }
}
