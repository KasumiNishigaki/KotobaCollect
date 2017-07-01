using UnityEngine;
using System.Collections;



public class Timer : MonoBehaviour {

	private float msTimer; 
	private float second;
	//private bool pause = false;

	public GameObject mojiCollectManager;




	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		msTimer += Time.deltaTime;
		second = Mathf.Round (msTimer);

		if(second >= 60){
			Application.LoadLevel ("Result");
		}
	}

	public void StopTimer(){

		Time.timeScale = 0.0f;

		mojiCollectManager.GetComponent<MojiCollectManager> ().PausePanel();


		/*
		if(pause == false){
			Time.timeScale = 0.0f;
			pause = true;
		}else{
			pause = false;
			Time.timeScale = 1.0f;
		}*/
	}

	public void Resumption (){

		Time.timeScale = 1.0f;

		GameObject obj = GameObject.Find ("Pause(Clone)");
		GameObject.Destroy (obj);

	}


	public void SceneLoad (){
		Time.timeScale = 1.0f;
		Application.LoadLevel ("StageSelect");

	}


}
