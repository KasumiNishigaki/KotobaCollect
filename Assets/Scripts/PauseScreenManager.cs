using UnityEngine;
using System.Collections;

public class PauseScreenManager : MonoBehaviour {

	public string nextScene;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SceneLoad (){

		Application.LoadLevel (nextScene);

	}

	public void Resumption (){

	

	}

}