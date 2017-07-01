using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ResultSceneLoad : MonoBehaviour {

	DateManager dateManager;

	public Text missionCollectText;
	public Text collectText;
	public Text missText;

	private int _collectCount;
	private int _missCount;

	public GameObject clear;
	public GameObject failed;
	public GameObject canvas;

	public GameObject level_bg;
	public List<Sprite> levelNameImages;

	public List<Sprite> stageName;
	public GameObject stage_n;

	public List<Sprite> stageBg;
	public GameObject stage_bg;


	// Use this for initialization
	void Start () {

		dateManager = DateManager.Instance;

		int level = dateManager.levelId;
		int stage = dateManager.stageId;

		Sprite setStageBg = stageBg [0];
		setStageBg = stageBg [stage - 1];
		stage_bg.GetComponent<Image> ().sprite = setStageBg;

		Sprite setStageName = stageName [0];
		setStageName = stageName [stage - 1];
		stage_n.GetComponent<Image> ().sprite = setStageName;

		Sprite setImage = levelNameImages [0];

		if(level == 1){
			setImage = levelNameImages [0];
		}else if(level == 2){
			setImage = levelNameImages [1];
		}else if(level == 3){
			setImage = levelNameImages [2];
		}

		level_bg.GetComponent<Image> ().sprite = setImage;
		missionCollectText.text = dateManager.clearLine.ToString ();
			

		_collectCount = dateManager.collectCount;
		_missCount = dateManager.missCount;

		if(_collectCount >= dateManager.clearLine){
			//成功
			Debug.Log("成功");
			AudioPlayer.PlaySe("Sounds/SE/20160114Result");
			clear.SetActive (true);

			//更新
			//さっきやったステージが最高ステージかつレベルが3だった場合クリアIDを+1更新する
			if((level == 3)&&(stage >= dateManager.clearedStageId)){
				print("ステージ1つクリアしました");
				if(stage >= 7){
					dateManager.complete = "true";
				}else{
					dateManager.clearedStageId = stage + 1;
					dateManager.clearedLevelId = 0;
				}
				dateManager.UpdateSaveDate ();
			}else{
				//さっきやったレベルが今までクリアしたレベルより大きければクリアIDを更新する
				if (level > dateManager.clearedLevelId) {
					print("レベル1つクリアしました");
					dateManager.clearedLevelId = level;
					dateManager.UpdateSaveDate ();
				}
			}


		}else{
			//失敗
			Debug.Log("失敗");
			AudioPlayer.PlaySe("Sounds/SE/Failed_20160209");
			failed.SetActive (true);
		
		}
	
		collectText.text = _collectCount.ToString();
		missText.text = _missCount.ToString();

	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
