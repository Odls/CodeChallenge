﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

internal class ChallengeView : MonoBehaviour{
	[SerializeField] Text title, description;
	[SerializeField] Button tipButton, editButton;
	ChallengeGroup group;
	ChallengeData challenge;
	internal void Show(ChallengeGroup p_group, ChallengeData p_challenge) {
		if ((p_group != null) && (p_challenge != null)) {
			group = p_group;
			challenge = p_challenge;

			title.text = $"{group.index:00}-{challenge.index:00}\n{challenge.title}";
			description.text = challenge.description;
			description.alignment = (challenge.description.Contains("}")) ? TextAnchor.UpperLeft : TextAnchor.UpperCenter;
			tipButton.gameObject.SetActive(challenge.tip != null);
		} else {
			group = null;
			challenge = null;
			title.text = "";
			description.text = "";
		}
	}

	public void Back() {
		MainManager.ToMenu();
	}

	public void Edit() {
		MainManager.EditChallenge(challenge);
	}
}
