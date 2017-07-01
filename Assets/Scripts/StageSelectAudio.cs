using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class StageSelectAudio : MonoBehaviour {

	public GameObject sound;
	public List<Sprite> soundBtn;
	DateManager dateManager;

	// Use this for initialization
	void Start () {

		if (PlayerPrefs.GetInt("Mute", 0) == 0)
		{
			AudioListener.volume = 1f;
			Sprite setSoundBtn = soundBtn [0];
			sound.GetComponent<Image> ().sprite = setSoundBtn;

		} else
		{
			AudioListener.volume = 0f;
			Sprite setSoundBtn = soundBtn [1];
			sound.GetComponent<Image> ().sprite = setSoundBtn;
		}
	
		AudioPlayer.PlayBgm ("Sounds/Common/StageSelect20160114");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AudioMute(){

		dateManager = DateManager.Instance;


		if (PlayerPrefs.GetInt("Mute", 0) == 0)
		{
			AudioListener.volume = 0f;
			PlayerPrefs.SetInt("Mute", 1);
			Sprite setSoundBtn = soundBtn [1];
			sound.GetComponent<Image> ().sprite = setSoundBtn;
		} else
		{
			AudioListener.volume = 1f;
			PlayerPrefs.SetInt("Mute", 0);
			Sprite setSoundBtn = soundBtn [0];
			sound.GetComponent<Image> ().sprite = setSoundBtn;
		}

		/*

		if(dateManager.sound_on == false){
			AudioListener.volume = 0;
			Sprite setSoundBtn = soundBtn [1];
			sound.GetComponent<Image> ().sprite = setSoundBtn;
			dateManager.sound_on = true;
		}else{
			dateManager.sound_on = false;
			AudioListener.volume = 1;
			Sprite setSoundBtn = soundBtn [0];
			sound.GetComponent<Image> ().sprite = setSoundBtn;
		}
		*/
	}
}
