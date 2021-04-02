using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/Expression")] public class ChallengeDataExpression : ChallengeData<ChallengeExpression> { }
public class ChallengeExpression : ChallengeBaseExpression {
	/*
		┌───────── 說明區 ─────────┐
		Expression 會被執行多次，每次 p_a, p_b, p_x 會傳入不同的值
		自行宣告區域變數 _y
		並計算方程式 y = x / a + b 的結果，將結果指派至 _y

		一行這樣的程式
		_y = p_x / p_a + p_b
		其實分為兩個部分

		左側的 [_y =] 是對 _y 的指派
		而右側的 [p_x / p_a + p_b] 只是計算，還未存入任何變數
		這部分就稱為 運算式

		運算式和變數一樣具有型別
		整數和整數間的計算結果也是整數、小數和小數間的計算結果也是小數
		沒有好好確認運算式的型別很容易發生意想不到的錯誤
		當型別不符預期時，就是明確轉換上場的時候了
		└──────────────────────┘
	*/

	//	┌───────── 挑戰區 ─────────┐
	//protected override void Expression(int p_a, float p_b, int p_x) {
	//	//┌── 固定區 ──┐
	//	Result.Print(_y);
	//	//└────────┘
	//}
	//	└──────────────────────┘
}
