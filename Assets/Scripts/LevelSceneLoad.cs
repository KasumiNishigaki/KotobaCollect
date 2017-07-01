using UnityEngine;
using System.Collections;

public class LevelSceneLoad : MonoBehaviour {

	public int levelId;
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
		dateManager.levelId = levelId;
		print ("レベル = " + dateManager.levelId);

		Application.LoadLevel (nextScene);

	}
}
