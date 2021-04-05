using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseWhile : ChallengeBase {
	public enum MAGIC{
		FireBall,
		FireStorm,
		Explosion
	}
	public ChallengeBaseWhile() {
		tests = new TestItem[] {
			new TestItem(
				"麻瓜",
				new TestField[] {
					new TestIntField{           showFormat="p_mp = {0}",    fieldValue = 0},
					new TestEnumField<MAGIC>{   showFormat="p_magic = {0}", fieldValue = MAGIC.FireBall}

				},
				new TestField[] {
					new TestStringField{        fieldValue = "沒魔了"}
				}
			),
			new TestItem(
				"見習生",
				new TestField[] {
					new TestIntField{           showFormat="p_mp = {0}",    fieldValue = 4},
					new TestEnumField<MAGIC>{   showFormat="p_magic = {0}", fieldValue = MAGIC.FireBall}

				},
				new TestField[] {
					new TestStringField{        fieldValue = "火球術"},
					new TestStringField{        fieldValue = "魔不夠"}
				}
			),
			new TestItem(
				"新手法師",
				new TestField[] {
					new TestIntField{           showFormat="p_mp = {0}",    fieldValue = 9},
					new TestEnumField<MAGIC>{   showFormat="p_magic = {0}", fieldValue = MAGIC.FireBall}

				},
				new TestField[] {
					new TestStringField{        fieldValue = "火球術"},
					new TestStringField{        fieldValue = "火球術"},
					new TestStringField{        fieldValue = "火球術"},
					new TestStringField{        fieldValue = "沒魔了"}
				}
			),
			new TestItem(
				"高級法師",
				new TestField[] {
					new TestIntField{           showFormat="p_mp = {0}",    fieldValue = 28},
					new TestEnumField<MAGIC>{   showFormat="p_magic = {0}", fieldValue = MAGIC.FireStorm}

				},
				new TestField[] {
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "魔不夠"}
				}
			),
			new TestItem(
				"高級法師",
				new TestField[] {
					new TestIntField{           showFormat="p_mp = {0}",    fieldValue = 80},
					new TestEnumField<MAGIC>{   showFormat="p_magic = {0}", fieldValue = MAGIC.FireStorm}

				},
				new TestField[] {
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "烈焰風暴"},
					new TestStringField{        fieldValue = "沒魔了"}
				}
			),
			new TestItem(
				"腦子有洞的高級法師",
				new TestField[] {
					new TestIntField{           showFormat="p_mp = {0}",    fieldValue = 80},
					new TestEnumField<MAGIC>{   showFormat="p_magic = {0}", fieldValue = MAGIC.Explosion}

				},
				new TestField[] {
					new TestStringField{        fieldValue = "魔不夠"}
				}
			),
			new TestItem(
				"ＯＯ",
				new TestField[] {
					new TestIntField{           showFormat="p_mp = {0}",    fieldValue = 100},
					new TestEnumField<MAGIC>{   showFormat="p_magic = {0}", fieldValue = MAGIC.Explosion}

				},
				new TestField[] {
					new TestStringField{        fieldValue = "爆裂魔法"},
					new TestStringField{        fieldValue = "沒魔了"}
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int, MAGIC>(p_test, WhileMagic);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void WhileMagic(int p_mp, MAGIC p_magic) { throw new NotDoException(); }
}
