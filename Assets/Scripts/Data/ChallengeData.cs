using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class ChallengeBase {
	internal TestItem[] tests;
	internal TestItem GetTest(int p_index) => tests[p_index];
	internal bool RunTest(int p_index) => RunTest(tests[p_index]);
	internal abstract bool RunTest(TestItem p_test);

	protected void CallFun<T1>(TestItem p_testItem, System.Action<T1> p_fun) {
		p_fun(
			(T1)p_testItem.inputs[0].value
		);
	}
	protected void CallFun<T1, T2>(TestItem p_testItem, System.Action<T1, T2> p_fun) {
		p_fun(
			(T1)p_testItem.inputs[0].value,
			(T2)p_testItem.inputs[1].value
		);
	}
	protected void CallFun<T1, T2, T3>(TestItem p_testItem, System.Action<T1, T2, T3> p_fun) {
		p_fun(
			(T1)p_testItem.inputs[0].value,
			(T2)p_testItem.inputs[1].value,
			(T3)p_testItem.inputs[2].value
		);
	}
	protected void CallFun<T1, T2, T3, T4>(TestItem p_testItem, System.Action<T1, T2, T3, T4> p_fun) {
		p_fun(
			(T1)p_testItem.inputs[0].value,
			(T2)p_testItem.inputs[1].value,
			(T3)p_testItem.inputs[2].value,
			(T4)p_testItem.inputs[3].value
		);
	}
}

public abstract class ChallengeData : ScriptableObject {
	[SerializeField] string mTitle;
	internal string title => mTitle;

	[SerializeField] ChallengeTip mTip;
	internal ChallengeTip tip => mTip;

	[Multiline]
	[SerializeField] string mDescription;
	internal string description => mDescription;

	internal int index { get; private set; }
	internal E_RESULT_STATE state { get; set; }
	internal virtual void Init(int p_index, E_RESULT_STATE p_state) {
		index = p_index;
		state = p_state;
	}

	internal abstract int testCount { get; }
	internal abstract TestItem GetTest(int p_index);
	internal abstract bool RunTest(int p_index);
}
public abstract class ChallengeData<ChallengeT> : ChallengeData
where ChallengeT : ChallengeBase, new(){
	ChallengeT challenge;

	internal override void Init(int p_index, E_RESULT_STATE p_state) {
		base.Init(p_index, p_state);
		challenge = new ChallengeT();
	}

	internal override int testCount => challenge.tests.Length;
	internal override TestItem GetTest(int p_index) => challenge.GetTest(p_index);
	internal override bool RunTest(int p_index) => challenge.RunTest(p_index);
}
