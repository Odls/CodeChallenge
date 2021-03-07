using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChallengeBase : ScriptableObject {
	[SerializeField] string mTitle;
	internal string title => mTitle;

	[SerializeField] ChallengeTip mTip;
	internal ChallengeTip tip => mTip;

	[Multiline]
	[SerializeField] string mDescription;
	internal string description => mDescription;

	internal int index { get; private set; }
	internal void Init(int p_index) {
		index = p_index;
	}

	internal abstract int testCount { get; }
	internal abstract TestItemBase GetTest(int p_index);
	internal abstract bool RunTest(int p_index);
}
public abstract class ChallengeBase<TestT> : ChallengeBase
where TestT : TestItemBase {
	[SerializeField] internal TestT[] tests;
	internal override int testCount => tests.Length;
	internal override TestItemBase GetTest(int p_index) => tests[p_index];
	internal override bool RunTest(int p_index) {
		return DoRunTest(tests[p_index]);
	}
	internal abstract bool DoRunTest(TestT p_test);
}
