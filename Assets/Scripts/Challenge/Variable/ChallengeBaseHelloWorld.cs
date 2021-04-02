using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseHelloWorld : ChallengeBase {
	public ChallengeBaseHelloWorld() {
		tests = new TestItem[] {
			new TestItem(
				"創世紀",
				new TestField[0],
				new TestField[] {
					new TestStringField{ fieldValue = "Hello World!"}
				}
			)
		};
	}

	internal override bool RunTest(TestItem p_test) {
		HelloWorld();
		return Result.CheckSame(p_test.expectedResults);
	}
	protected virtual void HelloWorld() { throw new NotDoException(); }
}
