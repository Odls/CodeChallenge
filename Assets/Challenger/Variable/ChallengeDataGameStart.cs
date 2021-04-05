using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/GameStart")] public class ChallengeDataGameStart : ChallengeData<ChallengeGameStart> {}
public class ChallengeGameStart : ChallengeBaseGameStart {
	/*
		┌───────── 說明區 ─────────┐
		每個挑戰腳本中都有 [說明區]、[固定區]、[挑戰區]
		[說明區]：說明挑戰中用到的技巧、過關的目標
		[固定區]：一些預先寫好的變數或函式，你應該在不更改 [固定區] 的狀況下達成挑戰目標
		[挑戰區]：你寫程式的地方

		基本上 [挑戰區] 裡只會有一支被註解的函式
		以此挑戰來說，就是 26 行的 GameStart 函式
		在註解的狀態下，視為這個挑戰還未進行
		解除註解的狀態下，進入 Unity 的播放模式並從選單選擇挑戰，就會執行程式，並判斷挑戰是否成功
		試著將 26 行的註解解除後回到 Unity 執行吧
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void GameStart() {}
	//	└──────────────────────┘
}
