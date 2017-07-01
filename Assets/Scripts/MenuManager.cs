using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MenuManager : MonoBehaviour {

	DateManager dateManager;

	public List<Button> stageButtons;

	// Use this for initialization
	void Start () {
		dateManager = DateManager.Instance;

		int clearedStageId = dateManager.clearedStageId;
		int clearedLevelId = dateManager.clearedLevelId;
	
		for(int i = 0; i < clearedStageId; i++){
			stageButtons[i].interactable = true;
			//print ("開けるステージの数 : " + i);
		}	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SceneLoad(){
		AudioPlayer.PlaySe("Sounds/SE/20160114Cancel");
		AudioPlayer.StopBgm();
		Application.LoadLevel ("Title");
	}
		
}
