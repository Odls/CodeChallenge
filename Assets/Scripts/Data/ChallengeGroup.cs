using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChallengeGroup : ScriptableObject{
	[SerializeField] string mTitle;
	public string title => mTitle;

	[SerializeField] ChallengeBase[] mChallenges;
	public ChallengeBase[] challenges => mChallenges;

	public int index { get; private set; }
	public void Init(int p_index) {
		index = p_index;
		int _butIndex = 0;
		foreach (var _but in challenges) {
			_but.Init(_butIndex);
			_butIndex++;
		}
	}
}
