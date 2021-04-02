using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Swap")] public class ChallengeDataSwap : ChallengeData<ChallengeSwap> { }
public class ChallengeSwap : ChallengeBaseSwap {
	/*
		┌───────── 說明區 ─────────┐
		Swap 會被執行多次，每次 p_a、p_b 會傳入不同的值
		試著將 p_a、p_b 兩個變數的值交換
		若需要的話，你可以自行宣告區域變數
		└──────────────────────┘
	*/

	//	┌───────── 挑戰區 ─────────┐
	//protected override void Swap(int p_a, int p_b) {
	//
	//	//┌── 固定區 ──┐
	//	Result.Print(p_a);
	//	Result.Print(p_b);
	//	//└────────┘
	//}
	//	└──────────────────────┘
}
