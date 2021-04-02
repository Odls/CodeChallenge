using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Conditionals/Enum")] public class ChallengeDataEnum : ChallengeData<ChallengeEnum> { }
public class ChallengeEnum : ChallengeBaseEnum<ChallengeEnum.OPERATOR> {
		/*
		┌───────── 說明區 ─────────┐
		EnumConditional 會被執行多次，每次會傳入不同的值
		同樣根據 p_operator 輸入，在 p_a、p_b 之間依序執行 加、減、乘、除 的運算
		當 p_operator 不為 加減乘除 時，一律輸出 0

		但這次 p_operator 不是數字，而是列舉
		列舉就是有名字的整數
		當一個數字在程式中代表的不是可計算的 "數量"，而是有意義的某個東西的的 "編號" 時
		就不該用純數字，而是意義清晰的列舉
		若只使用數字，之後重看程式會很難判斷每個數字的意思
		當你想把編號5改成編號6，要找遍所有程式碼裡的 5，一個個判斷每個5的意義是不是編號、該不該改成6，非常痛苦

		列舉不但可讀性高
		之後需要改動時，可藉由 IDE 重新命名、可在宣告區直接重新分配數值
		└──────────────────────┘
	*/

	//	┌───────── 挑戰區 ─────────┐

	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	public enum OPERATOR {

	}

	//protected override void EnumConditional(int p_a, int p_b, OPERATOR p_operator) {
	//
	//}
	//	└──────────────────────┘
}
