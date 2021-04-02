using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Conditionals/ConditionalOperator")] public class ChallengeDataConditionalOperator : ChallengeData<ChallengeConditionalOperator> { }
public class ChallengeConditionalOperator : ChallengeBaseConditionalOperator {
	/*
		┌───────── 說明區 ─────────┐
		if-else 陳述式 可以讓程式執行不同的程式碼區塊，做出完全不同的行為
		但有時只是要簡單的根據條件去改變一個數值

		同樣是 輸入為正數時，輸出字串 "正數"、輸入為負數時，輸出字串 "負數"
		但這次改在字串 _str 宣告處，直接用三元運算子判斷正負，並指派對應的初始值
		string _str = <Bool> ? <判斷成立時的數值> : <判斷不成立時的數值>;

		過度簡化程式碼，會讓之後回來看時難以理解
		但有時適度的簡化反而可以提升可讀性
		是否好讀的界線只能根據經驗拿捏
		└──────────────────────┘
	*/

	//	┌───────── 挑戰區 ─────────┐
	//protected override void ConditionalOperator(int p_value) {
	//	string _str;

	//	//┌── 固定區 ──┐
	//	Result.Print(_str);
	//	//└────────┘
	//}
	//	└──────────────────────┘
}
