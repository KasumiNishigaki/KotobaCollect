using UnityEngine;
using System.Collections;

public class SceneLoadScript : MonoBehaviour {

	public string nextScene;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	public void SceneLoad (){

		AudioPlayer.PlaySe("Sounds/SE/20160114Decision");
		AudioPlayer.StopBgm();
		Application.LoadLevel (nextScene);

	}

	public void SceneLoadBack (){
		
		AudioPlayer.PlaySe("Sounds/SE/20160114Cancel");
		Application.LoadLevel (nextScene);

	}
}
