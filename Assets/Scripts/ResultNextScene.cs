using UnityEngine;
using System.Collections;

public class ResultNextScene : MonoBehaviour {

	DateManager dateManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void Retry (){
		AudioPlayer.PlaySe("Sounds/SE/20160114Decision");

		Application.LoadLevel ("Scene1");

	}

	public void SceneLoad (){
		dateManager = DateManager.Instance;
		AudioPlayer.PlaySe("Sounds/SE/20160114Decision");
		if(dateManager.complete == "true"){
			dateManager.complete = "false";
			dateManager.UpdateSaveDate ();
			Application.LoadLevel ("ED");
		}else{
			Application.LoadLevel ("LevelSelect");
			AudioPlayer.PlayBgm ("Sounds/Common/StageSelect20160114");
		}
	}

}
