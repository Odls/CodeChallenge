using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Loop/LoopStairs")] public class ChallengeDataLoopStairs : ChallengeData<ChallengeLoopStairs> { }
public class ChallengeLoopStairs : ChallengeBaseLoopStairs {
	/*
		┌───────── 說明區 ─────────┐
		LoopStairs 會被執行多次，每次會傳入不同的值
		輸出層數為 p_count 的階梯

		例如 p_count 為 3 時，依序輸出三個字串組成階梯
		"■"
		"■■"
		"■■■"

		你可以使用 + 運算子組合字串，例如:
		string _str = "■";
		_str = "○" + _str + "◇";
		如此 _str 就會變成 "○■◇"

		在迴圈中用這種方式串接正確數量的 "■" 吧
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void LoopStairs(int p_count) {
	//
	//}
	//	└──────────────────────┘
}
