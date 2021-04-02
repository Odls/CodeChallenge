using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseSwitch<T> : ChallengeBase
where T : System.Enum {
	public ChallengeBaseSwitch() {
	tests = new TestItem[] {
			new TestItem(
				"42 + 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",        fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",        fieldValue = 6},
					new TestEnumField<T>{showFormat="p_operator = {0}", fieldValue = (T)System.Enum.ToObject(typeof(T), 0)}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 48}
				}
			),
			new TestItem(
				"42 - 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",         fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",         fieldValue = 6},
					new TestEnumField<T>{showFormat="p_operator = {0}",  fieldValue = (T)System.Enum.ToObject(typeof(T), 1)}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 36}
				}
			),
			new TestItem(
				"42 * 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",         fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",         fieldValue = 6},
					new TestEnumField<T>{showFormat="p_operator = {0}",  fieldValue = (T)System.Enum.ToObject(typeof(T), 2)}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 252}
				}
			),
			new TestItem(
				"42 / 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",         fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",         fieldValue = 6},
					new TestEnumField<T>{showFormat="p_operator = {0}",  fieldValue = (T)System.Enum.ToObject(typeof(T), 3)}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 7}
				}
			),
			new TestItem(
				"42 ? 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",         fieldValue = 42},
					new TestIntField{showFormat="p_b = {0}",         fieldValue = 6},
					new TestEnumField<T>{showFormat="p_operator = {0}",  fieldValue = (T)System.Enum.ToObject(typeof(T), 1000)}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 0}
				}
			),
			new TestItem(
				"40 + 2",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",         fieldValue = 40},
					new TestIntField{showFormat="p_b = {0}",         fieldValue = 2},
					new TestEnumField<T>{showFormat="p_operator = {0}",  fieldValue = (T)System.Enum.ToObject(typeof(T), 0)}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 42}
				}
			),
			new TestItem(
				"7 * 6",
				new TestField[] {
					new TestIntField{showFormat="p_a = {0}",         fieldValue = 7},
					new TestIntField{showFormat="p_b = {0}",         fieldValue = 6},
					new TestEnumField<T>{showFormat="p_operator = {0}",  fieldValue = (T)System.Enum.ToObject(typeof(T), 2)}
				},
				new TestField[] {
					new TestIntField{ fieldValue = 42}
				}
			)
		};
}

	internal override bool RunTest(TestItem p_test) {
		CallFun<int, int, T>(p_test, SwitchConditional);
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void SwitchConditional(int p_a, int p_b, T p_operator) { throw new NotDoException(); }
}
