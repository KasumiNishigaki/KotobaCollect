using UnityEngine;
using System.Collections;

public class StageSceneLoad : MonoBehaviour {

	public int stageId;
	public string nextScene;

	DateManager dateManager;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SceneLoad (){

		AudioPlayer.PlaySe("Sounds/SE/20160114Decision");

		//まず呼び出し
		dateManager = DateManager.Instance;
		dateManager.stageId = stageId;
		print ("ステージ = " + dateManager.stageId);
		Application.LoadLevel (nextScene);

	}
}
