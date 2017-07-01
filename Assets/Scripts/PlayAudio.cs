using UnityEngine;
using System.Collections;

public class PlayAudio : MonoBehaviour {

	int tapCount = 1;
	DateManager dateManager;

	// Use this for initialization
	void Start () {
		dateManager = DateManager.Instance;
		string key = dateManager.stageId.ToString() + "-" + dateManager.levelId.ToString();

		if (key == "7-3") {
			AudioPlayer.PlayBgm("Sounds/Common/Laststage_20160318");
		}else{
			AudioPlayer.PlayBgm("Sounds/Common/Play");
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void init(){
		tapCount = 1;
	}


	public void TapSE(){
		if(tapCount == 1){
			AudioPlayer.PlaySe("Sounds/SE/Moji1_20160119");
			tapCount++;
		}else if(tapCount == 2){
			AudioPlayer.PlaySe("Sounds/SE/Moji2_20160119");
			tapCount++;
		}else if(tapCount == 3){
			AudioPlayer.PlaySe("Sounds/SE/Moji3_20160119");
			tapCount++;
		}else if(tapCount == 4){
			AudioPlayer.PlaySe("Sounds/SE/Moji4_20160119");
			tapCount++;
		}else if(tapCount == 5){
			AudioPlayer.PlaySe("Sounds/SE/Moji5_20160119");
			tapCount++;
		}else if(tapCount == 6){
			AudioPlayer.PlaySe("Sounds/SE/Moji6_20160119");
			tapCount++;
		}else if(tapCount == 7){
			AudioPlayer.PlaySe("Sounds/SE/Moji7_20160119");
			tapCount++;
		}else if(tapCount == 8){
			AudioPlayer.PlaySe("Sounds/SE/Moji8_20160119");
			tapCount++;
		}else if(tapCount == 9){
			AudioPlayer.PlaySe("Sounds/SE/Moji9_20160317");
			tapCount++;
		}else if(tapCount == 10){
			AudioPlayer.PlaySe("Sounds/SE/Moji10_20160318");
			tapCount++;
		}else if(tapCount == 11){
			AudioPlayer.PlaySe("Sounds/SE/Moji11_20160318");
		}

	}
}
