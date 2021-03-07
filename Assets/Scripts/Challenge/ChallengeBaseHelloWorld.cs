using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBaseHelloWorld : ChallengeBase<TestItem> {
	internal override bool DoRunTest(TestItem p_test) {
		HelloWorld();
		return true;
	}

	protected virtual void HelloWorld() {
		throw new NotDoException();
	}
}
