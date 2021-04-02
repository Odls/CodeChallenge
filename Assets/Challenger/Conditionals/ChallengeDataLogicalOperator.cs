using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Conditionals/LogicalOperator")] public class ChallengeDataLogicalOperator : ChallengeData<ChallengeLogicalOperator> { }
public class ChallengeLogicalOperator : ChallengeBaseLogicalOperator {
	/*
		┌───────── 說明區 ─────────┐
		LogicalOperator 會被執行多次，每次會傳入不同的值
		有一矩形，左下角座標為 p_rectPos，寬高為 p_rectSize

			┌── p_rectSize.x ──┐
			▕　　　　　　　　　　　▕
		p_rectSize.y　　　　　　　　▕   ●p_point
			▕　　　　　　　　　　　▕
			●───────────┘
		p_rectPos

		若 p_point 在矩形內輸出 true，否則輸出 false

		將條件用 && 或 || 條件邏輯運算子串接，在 if 後的括號內完成複合條件判斷
		└──────────────────────┘
	*/


	//	┌───────── 挑戰區 ─────────┐
	//protected override void LogicalOperator(Vector2 p_point, Vector2 p_rectPos, Vector2 p_rectSize) {
	//	if( ) {
	//	//	┌── 固定區 ──┐
	//		Result.Print(true);
	//	} else {
	//		Result.Print(false);
	//	}
	//	//	└────────┘
	//}
	//	└──────────────────────┘
}
