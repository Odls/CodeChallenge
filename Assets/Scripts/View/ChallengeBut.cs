using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

internal class ChallengeBut : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	[SerializeField] Text title;
	[SerializeField] Image mark;

	ChallengeGroup group;
	ChallengeBase challenge;
	
	public int index { get; private set; }

	public void init(ChallengeGroup p_group, ChallengeBase p_challenge) {
		challenge = p_challenge;
		group = p_group;
		title.text = index.ToString("00 ") + challenge.title;
		RefreahState();
		MainManager.challengeButDict.Add(p_challenge.name, this);

	}
	public void RefreahState() {
		mark.sprite = MainManager.GetMark(challenge.state);
	}

	void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData) {
		if (MainManager.state == E_STATE.Menu) {
			MainManager.challengeView.Show(group, challenge);
		}
	}
	void IPointerExitHandler.OnPointerExit(PointerEventData eventData) {
		if (MainManager.state == E_STATE.Menu) {
			MainManager.challengeView.Show(null, null);
		}
	}
	public void OnClick() {
		MainManager.ToChallenge(group, challenge);
	}

	
}
