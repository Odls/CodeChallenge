using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/HelloVariable")] public class ChallengeDataHelloVariable : ChallengeData<ChallengeHelloVariable> { }
public class ChallengeHelloVariable : ChallengeBaseHelloVariable {
	/*
		┌───────── 說明區 ─────────┐
		寫程式的第二步就是操作變數

		首先解除 [固定區] HelloVariable 函式的註解後回到 Unity
		你會收到 [does not exist in the current context] 這項錯誤
		即找不到 numberVariable、decimalVariable、flagVariable、textVariable 這四個名字

		在 [挑戰區] 自行宣告這四個變數吧
		宣告的同時可以指派變數的初始值
		分別是整數 42、浮點數 3.14159、布林值 true、字串 "Hello Variable!"
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//protected override void HelloVariable() {
	//	Result.Print(numberVariable);
	//	Result.Print(decimalVariable);
	//	Result.Print(flagVariable);
	//	Result.Print(textVariable);
	//}
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//	└──────────────────────┘
}
