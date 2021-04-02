using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/SumVariable")] public class ChallengeDataSumVariable : ChallengeData<ChallengeSumVariable> { }
public class ChallengeSumVariable : ChallengeBaseSumVariable {
	/*
		┌───────── 說明區 ─────────┐
		變數 sum 初始值是 0
		每執行一次 SumVariable 須讓時 sum 增加 p_addNumber
		增加後，輸出 sum
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	int sum = 0;
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void SumVariable(int p_addNumber) {
	//}
	//	└──────────────────────┘
}
