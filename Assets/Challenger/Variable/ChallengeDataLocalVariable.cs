using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/LocalVariable")] public class ChallengeDataLocalVariable : ChallengeData<ChallengeLocalVariable> { }
public class ChallengeLocalVariable : ChallengeBaseLocalVariable {
	/*
		┌───────── 說明區 ─────────┐
		變數 _sum 初始值是 0
		但這一次它不是一般的成員變數，而是 LocalVariable 的區域變數
		同樣每執行一次 LocalVariable 須讓時 sum 增加 p_addNumber
		增加後，輸出 sum

		可以和前一個挑戰的輸出結果進行比較
		以了解成員變數和區域變數的差異
		└──────────────────────┘
	*/

	//	┌───────── 挑戰區 ─────────┐
	//protected override void LocalVariable(int p_addNumber) {
	//	//┌── 固定區 ──┐
	//	int _sum = 0;
	//	//└────────┘
	//
	//}
	//	└──────────────────────┘
}
