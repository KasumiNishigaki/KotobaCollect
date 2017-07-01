using UnityEngine;
using System.Collections;

public class TitleSceneLoad : MonoBehaviour {

	public string nextScene;
	public GameObject panel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SceneLoad (){

		AudioPlayer.StopBgm();
		AudioPlayer.PlaySe("Sounds/SE/20160114Decision");
		Application.LoadLevel (nextScene);
		//GameObject createPanel = Instantiate(panel, new Vector3 (0, 0, 0), Quaternion.identity) as GameObject;
		//createPanel.GetComponent<FadeScript> ().FadeOut();
	}

}
