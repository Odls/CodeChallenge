using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Loop/LoopTriangle")] public class ChallengeDataLoopTriangle : ChallengeData<ChallengeLoopTriangle> { }
public class ChallengeLoopTriangle : ChallengeBaseLoopTriangle {
	/*
		┌───────── 說明區 ─────────┐
		LoopTriangle 會被執行多次，每次會傳入不同的值
		輸出層數為 p_count 的三角形

		例如 p_count 為 3 時，依序輸出三個字串組成三角形
		"◣"
		"■◣"
		"■■◣"

		大致上和階梯類似，只需要想想如何加入 ◣ 的部分
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void LoopTriangle(int p_count) {
	//
	//}
	//	└──────────────────────┘
}
