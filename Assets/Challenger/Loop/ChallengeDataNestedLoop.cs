using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Loop/NestedLoop")] public class ChallengeDataNestedLoop : ChallengeData<ChallengeNestedLoop> { }
public class ChallengeNestedLoop : ChallengeBaseNestedLoop {
	/*
		┌───────── 說明區 ─────────┐
		輸出九九乘法表
		首先輸出字串 "2 × 1 = 2"，接著輸出 "2 × 2 = 4"
		輸出到 "2 × 9 = 18" 後，開始下一組 "3 × 1 = 3"，直到 "9 × 9 = 81" 為止

		你將使用兩層的巢狀迴圈，即在迴圈中再放入迴圈的結構
		for(;;) {
			for (;;) {

			}
		}
		它們可以各自有一個迴圈變數，用以累加不同的數值
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void NestedLoop() {
	//
	//}
	//	└──────────────────────┘
}
