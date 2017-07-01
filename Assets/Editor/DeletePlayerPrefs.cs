using UnityEngine;
using UnityEditor;
using System.Collections;

public class DeletePlayerPrefs : ScriptableObject {

	[MenuItem("Tools/DeletePlayerPrefs")]
	static void DeleteMyPlayerPrefs(){
		PlayerPrefs.DeleteAll();
	}
}
