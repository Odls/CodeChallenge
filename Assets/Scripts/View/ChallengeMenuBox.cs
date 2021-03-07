using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal class ChallengeMenuBox : MonoBehaviour{
	[SerializeField] ScrollRect scrollRect;
	[SerializeField] ChallengeGroupView challengeGroupViewPrefab;

	public void Init(ChallengeGroup[] p_challengeGroups) {
		foreach (var _group in p_challengeGroups) {
			var _groupView = Instantiate(challengeGroupViewPrefab, scrollRect.content);
			_groupView.init(_group);
		}
	}
}
