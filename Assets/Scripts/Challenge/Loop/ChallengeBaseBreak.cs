using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseBreak : ChallengeBase {
	public ChallengeBaseBreak() {
		tests = new TestItem[] {
			new TestItem(
				"野生的史萊姆出現了",
				new TestField[] {
					new TestIntField{		showFormat="p_enemyHp = {0}",	fieldValue = 1}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "對方逃跑了"}
				}
			),
			new TestItem(
				"野生的哥布林出現了",
				new TestField[] {
					new TestIntField{		showFormat="p_enemyHp = {0}",   fieldValue = 15}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "對方逃跑了"}
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
					new TestStringField{	fieldValue = "對方逃跑了"}
				}
			),
			new TestItem(
				"普通的路人出現了",
				new TestField[] {
					new TestIntField{		showFormat="p_enemyHp = {0}",	fieldValue = 12}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "攻擊"},
					new TestStringField{	fieldValue = "對方逃跑了"}
				}
			),
			new TestItem(
				"昨天死在這裡的路人變成殭屍了",
				new TestField[] {
					new TestIntField{		showFormat="p_enemyHp = {0}",	fieldValue = -18}
				},
				new TestField[] {
					new TestStringField{	fieldValue = "對方逃跑了"}
				}
			),
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int>(p_test, BreakAttack);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void BreakAttack(int p_enemyHp) { throw new NotDoException(); }
}
