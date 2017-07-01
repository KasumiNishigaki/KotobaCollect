using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Playground : MonoBehaviour {

	const string PLAYER_PREFS_TEST_KEY = "PlayerPrefsTestKey";

	List<string> defaultList = new List<string> () {
		"hoge", "huga", "piyo", "kasumichan"
	};

	List<string> testList = new List<string> ();

	// Use this for initialization
	void Start () {
		SetListToPlayerPrefs ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void SetListToPlayerPrefs () {
		print ("set");
		var saveData = "";

		foreach (var s in defaultList) {
			saveData += s + ",";
		}

		saveData = saveData.Substring (0, saveData.Length - 1);

		print (saveData);

		GetListFromPlayerPrefs (saveData);
	}

	public void GetListFromPlayerPrefs (string saveData) {
		print ("get");
		string[] datas = saveData.Split (new char[] {','});

		foreach (var data in datas) {
			testList.Add (data);
			print (data);
		}
	}
}
