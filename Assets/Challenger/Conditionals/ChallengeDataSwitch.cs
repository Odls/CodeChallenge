using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Conditionals/Switch")] public class ChallengeDataSwitch : ChallengeData<ChallengeSwitch> { }
public class ChallengeSwitch : ChallengeBaseSwitch<ChallengeSwitch.OPERATOR> {
	/*
		┌───────── 說明區 ─────────┐
		EnumConditional 會被執行多次，每次會傳入不同的值
		同樣根據 p_operator 輸入，在 p_a、p_b 之間依序執行 加、減、乘、除 的運算
		當 p_operator 不為 加減乘除 時，一律輸出 0

		這次將 if else 換成 switch 陳述式
		既然所有判斷都是在比對 p_operator 這個變數
		就該使用 switch 表示整個程式區塊就是在對 p_operator 的不同值做不同處裡
		讓程式的意義更加清晰
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	public enum OPERATOR {

	}

	//protected override void SwitchConditional(int p_a, int p_b, OPERATOR p_operator) {
	//
	//}
	//	└──────────────────────┘
}
