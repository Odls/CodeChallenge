using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Loop/LoopPyramid")] public class ChallengeDataLoopPyramid : ChallengeData<ChallengeLoopPyramid> { }
public class ChallengeLoopPyramid : ChallengeBaseLoopPyramid {
	/*
		┌───────── 說明區 ─────────┐
		LoopPyramid 會被執行多次，每次會傳入不同的值
		輸出層數為 p_count 的金字塔

		例如 p_count 為 3 時，依序輸出三個字串組成金字塔
		"　　▲"
		"　◢■◣"
		"◢■■■◣"

		這次除了要處理邊緣的斜面之外，還要注意左邊的空白
		那是一個和 "■" 寬度相同的全型空白"　"，不是 " "
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void LoopPyramid(int p_count) {
	//
	//}
	//	└──────────────────────┘
}
