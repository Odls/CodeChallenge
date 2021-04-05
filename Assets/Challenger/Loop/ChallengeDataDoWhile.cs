using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Loop/DoWhile")] public class ChallengeDataDoWhile : ChallengeData<ChallengeDoWhile> { }
public class ChallengeDoWhile : ChallengeBaseDoWhile {
	/*
		┌───────── 說明區 ─────────┐
		DoWhileAttack 會被執行多次，每次會傳入不同的值
		p_enemyHp 代表敵人的血量，重複輸出字串 "攻擊"，每次扣敵人 10 滴血，直到敵人血量歸零
		若敵人血量正好歸零，輸出"完美擊敗"
		若傷害超過敵人血量，輸出"傷害溢出 X"，X 為超出的數量

		例如敵人血量是 17
		17 Hp -10 (剩下7)
		7 Hp -10 (擊敗)
		輸出 "攻擊"、"攻擊"、"傷害溢出 3"

		你需要使用 do-while 陳述式
		do {
			<迴圈區塊>
		} while (<型別為 Bool 的條件值>)
		每次執行 <迴圈區塊> 後才會檢查 <條件值>
		若成立便再執行一次

		和 while 不同，一個條件在前、一個在後
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void DoWhileAttack(int p_enemyHp) {
	//
	//}
	//	└──────────────────────┘
}
