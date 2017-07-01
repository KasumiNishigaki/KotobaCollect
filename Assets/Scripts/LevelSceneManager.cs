using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LevelSceneManager : MonoBehaviour {


	DateManager dateManager;

	//public GameObject titlePrefab; 
	public GameObject canvas;

	private int bgNum = 0;

	public List<Sprite> levelSelect_bg;
	public GameObject levelBg;

	public List<Sprite> townName;
	public GameObject townNameLabel;

	public List<Button> levelButtons;


	// Use this for initialization
	void Start () {

		dateManager = DateManager.Instance;
		bgNum = dateManager.stageId;

		int clearedStageId = dateManager.clearedStageId;
		int clearedLevelId = dateManager.clearedLevelId;

		if(bgNum >= clearedStageId){
			//最高ステージにいる場合
			//クリアIDより１つ多くレベルボタンを開ける
			for (int i = 0; i <= clearedLevelId; i++) {
				if (i == 3) {
					break;
				}
				levelButtons [i].interactable = true;
			}	
		}else{
			//今いるステージがクリアIDより小さければレベルボタン全部開ける
			for(int i = 0; i < 3; i++){
				levelButtons[i].interactable = true;
			}
		}

		Sprite setBg = levelSelect_bg [0];
		//levelBg.GetComponent<Image> ().sprite = setBg;

		Sprite setNameBg = townName [0];
		//townNameLabel.GetComponent<Image> ().sprite = setNameBg;


		if(bgNum == 1){
			setBg = levelSelect_bg [0];
			setNameBg = townName [0];
		}else if(bgNum == 2){
			setBg = levelSelect_bg [1];
			setNameBg = townName [1];
		}else if(bgNum == 3){
			setBg = levelSelect_bg [2];
			setNameBg = townName [2];
		}else if(bgNum == 4){
			setBg = levelSelect_bg [3];
			setNameBg = townName [3];
		}else if(bgNum == 5){
			setBg = levelSelect_bg [4];
			setNameBg = townName [4];
		}else if(bgNum == 6){
			setBg = levelSelect_bg [5];
			setNameBg = townName [5];
		}else if(bgNum == 7){
			setBg = levelSelect_bg [6];
			setNameBg = townName [6];
		}
			
		levelBg.GetComponent<Image> ().sprite = setBg;
		townNameLabel.GetComponent<Image> ().sprite = setNameBg;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
