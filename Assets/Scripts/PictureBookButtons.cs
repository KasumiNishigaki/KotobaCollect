using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PictureBookButtons : MonoBehaviour {

	public int stageId;
	public Sprite stage_name;
	public GameObject stage_n;
	public Sprite stage_bg;
	public GameObject stage_b;
	public GameObject buttonSet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void DicButtons(){
		stage_n.GetComponent<Image> ().sprite = stage_name;
		stage_b.GetComponent<Image> ().sprite = stage_bg;

		buttonSet.GetComponent<PictureBookManager> ().ClearedWord(stageId);
		buttonSet.GetComponent<PictureBookManager> ().ButtonSetPosition(this.gameObject);
	}
		
}
