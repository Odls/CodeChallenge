using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Conditionals/If")] public class ChallengeDataIf : ChallengeData<ChallengeIf> { }
public class ChallengeIf : ChallengeBaseIf {
	/*
		┌───────── 說明區 ─────────┐
		IfConditional 會被執行多次，每次 p_value 會傳入不同的值
		當輸入為正數(包含0)時，輸出字串 "正數"
		當輸入為負數時，輸出字串 "負數"

		你需要使用 if-else 陳述式
		if(<型別為 Bool 的條件值>) {
			<條件成立時的區塊>
		} else {
			<條件不成立時的區塊>
		}

		if 後面需要一個型別為 Bool 的值進行條件是否成立的判斷，變數、常數、運算式 皆可
		經過條件判斷後，程式流程將被導向不同的區塊
		透過這些流程變化就能表現出各種不同的行為
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void IfConditional(int p_value) {
	//
	//}
	//	└──────────────────────┘
}
