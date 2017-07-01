using UnityEngine;
using System.Collections;

public class FadeOut : MonoBehaviour {

	DateManager dateManager;

	// Use this for initialization
	void Start () {
		dateManager = DateManager.Instance;
		iTween.FadeTo(gameObject, iTween.Hash(
			"alpha", 0, 
			"time", 2.0f ,
			"oncomplete","EndAction",
			"oncompletetarget",gameObject));
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
			if(dateManager.op_ == "false"){
				Application.LoadLevel ("OP");
			}else{
				Application.LoadLevel ("Title");
			}
		}
	}
		
	public void EndAction(){
		//Debug.Log("end");
		if(dateManager.op_ == "false"){
			Application.LoadLevel ("OP");
		}else{
			Application.LoadLevel ("Title");
		}
	}

	/*
	public void FadeOut(){
		iTween.FadeTo(fade, iTween.Hash(
			"alpha", 0, 
			"time", 2.5f ,
			"oncomplete","EndAction",
			"oncompletetarget",fade));
	}

	void EndAction(){
		//Debug.Log("end");
		Application.LoadLevel (nextScene);
	}*/
}
