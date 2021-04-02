using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Variable/TypeConversion")] public class ChallengeDataTypeConversion : ChallengeData<ChallengeTypeConversion> { }
public class ChallengeTypeConversion : ChallengeBaseTypeConversion {
	/*
		┌───────── 說明區 ─────────┐
		TypeConversion 會被執行多次，每次 p_int、p_float 會傳入不同的值

		首先將 p_int 指派給 _intToFloat
		因為浮點數也可以表示整數，可以普通的指派
		程式自動將整數轉換成浮點數存入 _intToFloat，這稱為隱含轉換

		接者將 p_float 指派給 _floatToInt
		因為整數無法表示浮點數，真硬存進去數值的小數資訊勢必會遺失
		程式不會自動進行這種可能引發數值錯誤的轉換
		但你可以使用 (int)p_float 強制將其轉為整數，這稱為明確轉換
		告知程式你很清楚這裡有一個轉換行為，你確實允許轉換時丟棄小數部造成的數值改變
		└──────────────────────┘
	*/

	//	┌───────── 挑戰區 ─────────┐
	//protected override void TypeConversion(int p_int, float p_float) {
	//	//┌── 固定區 ──┐
	//	float _intToFloat;
	//	int _floatToInt;
	//	//└────────┘
	//
	//
	//	//┌── 固定區 ──┐
	//	Result.Print(_intToFloat);
	//	Result.Print(_floatToInt);
	//	//└────────┘
	//}
	//	└──────────────────────┘
}
