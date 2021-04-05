using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Loop/While")] public class ChallengeDataWhile : ChallengeData<ChallengeWhile> { }
public class ChallengeWhile : ChallengeBaseWhile {
	/*
		┌───────── 說明區 ─────────┐
		WhileMagic 會被執行多次，每次會傳入不同的值
		p_mp 代表初始魔力量，重複輸出魔法的名字，每次輸出都會花費對應的魔力
		MAGIC 列舉值為要輸出的魔法種類，有三種可能
		FireBall 花費 3 魔力，輸出 "火球術"
		FireStorm 花費 10 魔力，輸出 "烈焰風暴"
		Explosion 花費 100 魔力，輸出 "爆裂魔法"
		輸出魔法直到魔力不足為止
		不足後若魔力剛好歸零，輸出字串 "沒魔了"，否則輸出"魔不夠"

		例如初始魔力量7，使用火球術
		7 Mp -3 (剩下4)
		4 Mp -3 (剩下1)
		輸出 "火球術"、"火球術"、"魔不夠"

		你需要使用 while 陳述式
		while (<型別為 Bool 的條件值>) {
			<迴圈區塊>
		}
		每次執行 <迴圈區塊> 前會先檢查 <條件值>
		若成立便執行一次後繼續檢查

		注意!! 因為 while 迴圈沒有指定次數，萬一 <條件值> 一直無法成立，迴圈將永遠進行下去
		這種狀況稱為 "無限迴圈" 或 "死迴圈"，例如你只要寫
		while(true) {
			<迴圈區塊>
		}
		條件永遠是 true，程式就會完全卡死，陷入迴圈中再也無法執行其他任何程式碼
		包含 Unity 編輯器都會一起卡住，呈現應用程式沒有回應的狀態
		只能叫出工作管理員強行停止 Unity
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void WhileMagic(int p_mp, MAGIC p_magic) {
	//
	//}
	//	└──────────────────────┘
}
