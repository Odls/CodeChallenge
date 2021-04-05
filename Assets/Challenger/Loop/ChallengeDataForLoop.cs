using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Loop/ForLoop")] public class ChallengeDataForLoop : ChallengeData<ChallengeForLoop> { }
public class ChallengeForLoop : ChallengeBaseForLoop {
	/*
		┌───────── 說明區 ─────────┐
		ForLoop 會被執行多次，每次會傳入不同的值
		從 p_startNumber 開始依序輸出連續的數字，數量為 p_numberCount

		當一個程式區塊需要被重複執行時，就可以使用迴圈
		最基本的就是 for 陳述式

		for(<初始化>; <迴圈條件>; <迭代器>){
			<迴圈區塊>
		}

		<初始化> 在進入迴圈時執行一次
		<迴圈條件> 型別為 Bool 的條件值
		<迭代器> 每當迴圈區塊執行後額外執行
		<迴圈區塊> 想重複執行的內容

		最普遍的用法就是用來操作一個迴圈變數進行計數
		for (int i= 0; i< _count; i++) {

		}
		<初始化> 初始將 i 設為 0
		<迴圈條件> i 達到目標次數 _count 為止都繼續執行
		<迭代器> 每次執行後將 i 累加

		如此就能將<迴圈區塊>中的程式重複執行 _count 次
		└──────────────────────┘
	*/

	//	┌───────── 固定區 ─────────┐
	//	└──────────────────────┘

	//	┌───────── 挑戰區 ─────────┐
	//protected override void ForLoop(int p_startNumber, int p_numberCount) {
	//
	//}
	//	└──────────────────────┘
}
