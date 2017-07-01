using UnityEngine;
using System.Collections;

public class TitleAudio : MonoBehaviour {

	//DateManager dateManager;


	// Use this for initialization
	void Start () {

		/*
		 * Vector3 targetPos = new Vector3 (4.42f, 1.9f, 0.0f);
		 * iTween.MoveTo(star,iTween.Hash (
			"position", targetPos,
			"time", 1.0f,
			"islocal",true,
			"oncompletetarget",this.gameObject,
			"easetype",iTween.EaseType.easeOutQuart));

		*/

		AudioPlayer.PlayBgm("Sounds/Common/Title20160114");
		//AudioPlayer.PlaySe("Sounds/SE/se_maoudamashii_onepoint33");


	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
