using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/HelloWorld")] public class ChallengeDataHelloWorld : ChallengeData<ChallengeHelloWorld> { }
public class ChallengeHelloWorld : ChallengeBaseHelloWorld {
	/*
		┌───────── 說明區 ─────────┐
		輸出結果是寫程式的第一步
		畢竟看到結果才能知道程式是否正確

		實際製作遊戲時可使用 Debug.Log("字串") 將各種資訊輸出到 Console 視窗
		在這個遊戲中則改用 Result.Print("字串") 輸出為挑戰結果

		試著輸出 "Hello World!" 吧
		向黑暗的未來揮手
		歡迎墜落這個數位世界
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void HelloWorld() {

	//}
	//	└──────────────────────┘
}
