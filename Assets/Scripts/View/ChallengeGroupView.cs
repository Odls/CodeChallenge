using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal class ChallengeGroupView : MonoBehaviour{
	[SerializeField] Text title;
	[SerializeField] ChallengeBut challengeButPrefab;
	ChallengeGroup challengeGroup;

	internal void init(ChallengeGroup p_group) {
		challengeGroup = p_group;
		title.text = p_group.index.ToString("00 ") + p_group.title;

		foreach (var _challenge in challengeGroup.challenges) {
			var __challengeBut = Instantiate(challengeButPrefab, transform);
			__challengeBut.init(challengeGroup, _challenge);
		}
	}
}
