using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeBaseGameStart : ChallengeBase{
	public ChallengeBaseGameStart() {
		tests = new TestItem[] {
			new TestItem(
				"遊戲開演",
				new TestField[0],
				new TestField[0]
			)
		};
	}
	internal override bool RunTest(TestItem p_test) {
		GameStart();
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void GameStart() { throw new NotDoException(); }
}
