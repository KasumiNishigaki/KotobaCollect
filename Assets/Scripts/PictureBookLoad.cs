﻿using UnityEngine;
using System.Collections;

public class PictureBookLoad : MonoBehaviour {

	public string nextScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SceneLoad (){

		AudioPlayer.PlaySe("Sounds/SE/20160114Decision");
		Application.LoadLevel (nextScene);

	}
}
