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
	internal E_RESULT_STATE state { get; set; }
	internal void Init(int p_index, E_RESULT_STATE p_state) {
		index = p_index;
		state = p_state;
	}

	#region Test
	internal TestItem[] tests;
	internal int testCount => tests.Length;
	internal TestItem GetTest(int p_index) => tests[p_index];
	internal bool RunTest(int p_index) { return RunTest(tests[p_index]); }
	internal abstract bool RunTest(TestItem p_test);
	#endregion
}
