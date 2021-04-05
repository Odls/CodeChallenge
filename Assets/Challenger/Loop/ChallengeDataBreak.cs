using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Loop/Break")] public class ChallengeDataBreak : ChallengeData<ChallengeBreak> { }
public class ChallengeBreak : ChallengeBaseBreak {
	/*
		┌───────── 說明區 ─────────┐
		BreakAttack 會被執行多次，每次會傳入不同的值
		p_enemyHp 代表敵人的血量，重複輸出字串 "攻擊"，每次扣敵人 10 滴血
		但這次不能把對手打死，必需打到正好再打一次就死了的邊緣

		你需要使用 break 陳述式，它通常配合條件判斷使用
		當不需要繼續執行時直接強制跳出迴圈
		while(true){
			執行某些動作

			if(不想再做了){
				break;
			}
		}
		不只是 do-while，你也可以用 break 跳出 while 或 for

		總結關於迴圈的離開時機
		要在執行前檢查就用 while
		要在執行後檢查就用 do-while
		其他執行到一半會突然離開的特殊狀況就用 break
		└──────────────────────┘
	*/


	//	┌───────── 挑戰區 ─────────┐
	protected override void BreakAttack(int p_enemyHp) {
		//	┌── 固定區 ──┐
		int _hp = p_enemyHp;
		do {
		//	└────────┘

			if((_hp - 10) <= 0) {
				break;
			}

		//	┌── 固定區 ──┐
			Result.Print("攻擊");
			_hp -= 10;
		} while (_hp > 0);

		if ((_hp != p_enemyHp) && (_hp <= 0)) {
			Result.Print("對方被打死了");
		} else {
			Result.Print("對方逃跑了");
		}
		//	└────────┘
	}
	//	└──────────────────────┘
}
