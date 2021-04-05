using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Conditionals/If ElseIf")] public class ChallengeDataElseIf : ChallengeData<ChallengeElseIf> { }
public class ChallengeElseIf : ChallengeBaseElseIf {
	/*
		┌───────── 說明區 ─────────┐
		ElseIfConditional 會被執行多次，每次 p_value 會傳入不同的值
		當 p_operator 輸入為 0~3 時，在 p_a、p_b 之間依序執行 加、減、乘、除 的運算
		即 p_operator 為 0 時，輸出 p_a + p_b，當 p_operator 為 1 時，輸出 p_a - p_b，以此類推
		當 p_operator 不為 0~3 時，一律輸出 0

		你需要使用 if-else if 陳述式
		if(<條件值1>) {
			<條件成立時的區塊>
		} else if(<條件值2>) {
			<條件成立時的區塊>
		} else if(<條件值3>) {
			<條件成立時的區塊>
		} else {
			<以上條件皆不成立時的區塊>
		}
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void ElseIfConditional(int p_a, int p_b, int p_operator) {
	//
	//}
	//	└──────────────────────┘
}
