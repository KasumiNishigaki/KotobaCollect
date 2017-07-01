using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class MenuButtonManager : MonoBehaviour {

	public GameObject menu_btn;
	public List<Sprite> MenuBtn;
	public GameObject menu;
	private bool menu_iTween;
	Vector3 defaultPosition;
	Vector3 transPosition;
	// Use this for initialization
	void Start () {
		defaultPosition = menu.transform.localPosition;
		transPosition = defaultPosition;
		transPosition.x += 200;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MenuButton(){

		if(menu_iTween == false){
			AudioPlayer.PlaySe("Sounds/SE/20160114Decision");
			Sprite setMenuBtn = MenuBtn [1];
			menu_btn.GetComponent<Image> ().sprite = setMenuBtn;

			//Vector3 targetPos = new Vector3 (-368.0f, 262.0f, 0.0f);
			//this.transform.Translate (new Vector3 (120, 0, 0));

			iTween.MoveTo(menu,iTween.Hash (
				"position",transPosition,
				"time", 0.8f,
				"islocal",true,
				"oncompletetarget",this.gameObject,
				"easetype",iTween.EaseType.easeOutQuart));
			menu_iTween = true;
		}else{
			menu_iTween = false;
			AudioPlayer.PlaySe("Sounds/SE/20160114Cancel");
			Sprite setMenuBtn = MenuBtn [0];
			menu_btn.GetComponent<Image> ().sprite = setMenuBtn;

			//Vector3 targetPos = new Vector3 (-580.0f, 262.0f, 0.0f);
			//defaultPosition.x += -50.0f;
			iTween.MoveTo(menu,iTween.Hash (
				"position", defaultPosition,
				"time", 0.8f,
				"islocal",true,
				"oncompletetarget",this.gameObject,
				"easetype",iTween.EaseType.easeOutQuart));
		}

	}
}
