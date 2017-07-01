using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;


public class MojiCollectManager : MonoBehaviour {

	DateManager dateManager;

	public List<Vector3> posList = new List<Vector3> ();
	public GameObject canvas;
	public GameObject moji;
	private GameObject createImage;

	public GameObject panel;

	public GameObject recet;
	public Text CollectedText;
	private bool clear = false;
	private bool unClear = false;


	public List<Sprite> bgImages;
	public List<Sprite> bg_2Images;
	public List<Sprite> maruImages;
	public List<Sprite> maru2Images;
	public List<Sprite> maru3Images;
	public GameObject bgImage;
	public GameObject bg_2Image;
	private Sprite setBgImage;
	private Sprite setBg_2Images;
	private Sprite setMaruImages;
	private Sprite setMaru2Images;
	private Sprite setMaru3Images;

	private Image buttonImage_;

	public GameObject hint;
	public Text hintText;

	public GameObject judgeCollect;
	public GameObject judgeInCollect;

	public GameObject tapSE;

	public int collectCount = 0;
	public int missCount = 0;

	public Text clearLineText;
	public Text currentClearText;

	public List<GameObject> listHitCircle = new List<GameObject> ();


	public List<GameObject> listMoji = new List<GameObject> ();
	public List<int> listCollectedMojiId;

	public GameObject lineRendererManager;

	private string checkWord;

	public List<Sprite> hintImages;
	public GameObject hintIcon;
	private Sprite setHintImage;

	bool isTouchMoji;
	GameObject prevTouchMoji;

	int[] mojiIds = { 0, 1, 2, 3, 4 };
	char[] mojis = new char[5];

	//文字回収モードか否か
	bool isCollectMoji = false;

	void init(){
		dateManager.collectCount = 0;
		dateManager.missCount = 0;
		collectCount = 0;
		missCount = 0;
		//print ("tutrial: " + dateManager.tutrial);
	}

	void HintIcon(){
		dateManager = DateManager.Instance;
		string key = dateManager.stageId.ToString() + "-" + dateManager.levelId.ToString();

		if(key == "2-2"){
			setHintImage = hintImages [1];
		}else if(key == "2-3"){
			setHintImage = hintImages [2];
		}else if(key == "3-1"){
			setHintImage = hintImages [3];
		}else if(key == "3-2"){
			setHintImage = hintImages [4];
		}else if(key == "3-3"){
			setHintImage = hintImages [5];
		}else if((key == "4-1")||(key == "4-2")){
			setHintImage = hintImages [6];
		}else if(key == "5-1"){
			setHintImage = hintImages [7];
		}else if(key == "5-2"){
			setHintImage = hintImages [8];
		}else if(key == "6-1"){
			setHintImage = hintImages [9];
		}else if(key == "6-2"){
			setHintImage = hintImages [10];
		}else{
			setHintImage = hintImages [0];
		}

		hintIcon.GetComponent<Image> ().sprite = setHintImage;

	}

	void stageImages(){

		dateManager = DateManager.Instance;
		int stageKey = dateManager.stageId;
		int levelKey = dateManager.levelId;

		if(stageKey == 1){
			setBgImage = bgImages [0];
			setBg_2Images = bg_2Images [0];
			setMaruImages = maruImages [0];
			setMaru2Images = maru2Images [0];
			setMaru3Images = maru3Images [0];
		}else if(stageKey == 2){
			setBgImage = bgImages [1];
			setBg_2Images = bg_2Images [1];
			setMaruImages = maruImages [1];
			setMaru2Images = maru2Images [1];
			setMaru3Images = maru3Images [1];
		}else if(stageKey == 3){
			setBgImage = bgImages [2];
			setBg_2Images = bg_2Images [2];
			setMaruImages = maruImages [2];
			setMaru2Images = maru2Images [2];
			setMaru3Images = maru3Images [2];
		}else if(stageKey == 4){
			setBgImage = bgImages [3];
			setBg_2Images = bg_2Images [3];
			setMaruImages = maruImages [3];
			setMaru2Images = maru2Images [3];
			setMaru3Images = maru3Images [3];
		}else if(stageKey == 5){
			setBgImage = bgImages [4];
			setBg_2Images = bg_2Images [4];
			setMaruImages = maruImages [4];
			setMaru2Images = maru2Images [4];
			setMaru3Images = maru3Images [4];
		}else if(stageKey == 6){
			setBgImage = bgImages [5];
			setBg_2Images = bg_2Images [5];
			setMaruImages = maruImages [5];
			setMaru2Images = maru2Images [5];
			setMaru3Images = maru3Images [5];
		}else if((stageKey == 7)&&(levelKey == 3)){
			print ("最終ステージ");
			setBgImage = bgImages [6];
			setBg_2Images = bg_2Images [7];
			setMaruImages = maruImages [7];
			setMaru2Images = maru2Images [7];
			setMaru3Images = maru3Images [7];
		}else{
			setBgImage = bgImages [6];
			setBg_2Images = bg_2Images [6];
			setMaruImages = maruImages [6];
			setMaru2Images = maru2Images [6];
			setMaru3Images = maru3Images [6];
		}

		bgImage.GetComponent<Image> ().sprite = setBgImage;
		bg_2Image.GetComponent<Image> ().sprite = setBg_2Images;
		moji.GetComponent<Image> ().sprite = setMaruImages;

		for(int i = 0; i < listMoji.Count; i++){
			listMoji[i].GetComponent<Image> ().sprite = setMaruImages;
		}

		if(stageKey == 5){
			for(int i = 0; i < listMoji.Count; i++){
				GameObject obj = listMoji[i].transform.Find("Text").gameObject;
				obj.GetComponent<Text> ().color = Color.white;
			}
			GameObject obj_ = moji.transform.Find("Text").gameObject;
			obj_.GetComponent<Text> ().color = Color.white;
		}

	}


	void resetListMoji(){
		
		foreach (GameObject go in listMoji){
			Destroy(go.gameObject);
		}
		listMoji.Clear ();
		posList.Clear ();

		//print ("listmojiCount = " + listMoji.Count);

	}

	void recieveNewWord(string word) {
		
		checkWord = word;

		Array.Resize (ref mojis, word.Length);
		mojis = word.ToCharArray();

		Array.Resize (ref mojiIds, word.Length);
		for (int i = 0; i < mojiIds.Length; i++) {
			mojiIds [i] = i;
		}

		setPosList (word.Length);
		giveHint (word);
		ShuffleMojiIds ();
	
	}

	void setPosList(int wordLength){
		resetListMoji ();

		//print ("before created listmojiCount = " + listMoji.Count);

		//print ("t: " + dateManager.tutrial);

		//print ("length: " + wordLength);

		if (wordLength == 2) {

			if (dateManager.tutrial == "false") {
				posList.Add (new Vector3 (-180, 61, 0));
				posList.Add (new Vector3 (200, -150, 0));
			} else {
				int index0 = UnityEngine.Random.Range (0, 4);

				if (index0 == 0) {
					posList.Add (new Vector3 (90, -174, 0));
					posList.Add (new Vector3 (-293, 61, 0));
				} else if (index0 == 1) {
					posList.Add (new Vector3 (159, -161, 0));
					posList.Add (new Vector3 (-159, -161, 0));
				} else if (index0 == 2) {
					posList.Add (new Vector3 (99, -161, 0));
					posList.Add (new Vector3 (259, 72, 0));
				} else if (index0 == 3) {
					posList.Add (new Vector3 (122, -104, 0));
					posList.Add (new Vector3 (-134, 57, 0));
				}
			}
		}

		if (wordLength == 3) {
			int index1 = UnityEngine.Random.Range (0, 3);

			if (index1 == 0) {
				posList.Add (new Vector3 (90, -174, 0));
				posList.Add (new Vector3 (-293, 61, 0));
				posList.Add (new Vector3 (231, 72, 0));
			} else if (index1 == 1) {
				posList.Add (new Vector3 (159, -161, 0));
				posList.Add (new Vector3 (-159, -161, 0));
				posList.Add (new Vector3 (-159, 72, 0));
			} else if (index1 == 2) {
				posList.Add (new Vector3 (99, -161, 0));
				posList.Add (new Vector3 (259, 72, 0));
				posList.Add (new Vector3 (-282, -161, 0));
			}
		}

		if (wordLength == 4) {
			int index2 = UnityEngine.Random.Range (0, 3);

			if (index2 == 0) {
				posList.Add (new Vector3 (90, -174, 0));
				posList.Add (new Vector3 (-293, 61, 0));
				posList.Add (new Vector3 (231, 72, 0));
				posList.Add (new Vector3 (-60, -12, 0));
			} else if (index2 == 1) {
				posList.Add (new Vector3 (159, -161, 0));
				posList.Add (new Vector3 (-159, -161, 0));
				posList.Add (new Vector3 (-159, 72, 0));
				posList.Add (new Vector3 (159, 72, 0));
			} else if (index2 == 2) {
				posList.Add (new Vector3 (99, -161, 0));
				posList.Add (new Vector3 (259, 72, 0));
				posList.Add (new Vector3 (-282, -161, 0));
				posList.Add (new Vector3 (-122, -72, 0));
			}
		}

		if(wordLength == 5){
			int index3 = UnityEngine.Random.Range(0, 3);

			if(index3 == 0){
				posList.Add (new Vector3(-186, -196, 0));
				posList.Add (new Vector3 (-239, 90, 0));
				posList.Add (new Vector3 (276,-133, 0));
				posList.Add (new Vector3 (-23,-42, 0));
				posList.Add (new Vector3 (183,44, 0));
			}else if(index3 == 1){
				posList.Add (new Vector3(-126,-179, 0));
				posList.Add (new Vector3 (-219,14, 0));
				posList.Add (new Vector3 (143,-176, 0));
				posList.Add (new Vector3 (-3,124, 0));
				posList.Add (new Vector3 (226,21, 0));
			}else if(index3 == 2){
				posList.Add (new Vector3(-23,-179, 0));
				posList.Add (new Vector3 (-315,-16, 0));
				posList.Add (new Vector3 (286,-176, 0));
				posList.Add (new Vector3 (-80,124, 0));
				posList.Add (new Vector3 (159,31, 0));
			}

		}

		if(wordLength == 6){
			int index4 = UnityEngine.Random.Range(0, 2);

			if(index4 == 0){
				posList.Add (new Vector3(72,-91, 0));
				posList.Add (new Vector3 (166,119, 0));
				posList.Add (new Vector3 (-319,-55, 0));
				posList.Add (new Vector3 (-132,116, 0));
				posList.Add (new Vector3 (319,-82, 0));
				posList.Add (new Vector3 (-154,-182, 0));
			}else if(index4 == 1){
				posList.Add (new Vector3(0,-190, 0));
				posList.Add (new Vector3 (174,50, 0));
				posList.Add (new Vector3 (174,-136, 0));
				posList.Add (new Vector3 (-174,-135, 0));
				posList.Add (new Vector3 (-174,50, 0));
				posList.Add (new Vector3 (0,130, 0));
			}

		}

		if(wordLength == 7){
			posList.Add (new Vector3(-98,-141, 0));
			posList.Add (new Vector3 (-323,-44, 0));
			posList.Add (new Vector3 (-193,123, 0));
			posList.Add (new Vector3 (192,144, 0));
			posList.Add (new Vector3 (334,-16, 0));
			posList.Add (new Vector3 (203,-176, 0));
			posList.Add (new Vector3 (-3,-14, 0));
		}

		if(wordLength == 8){
			posList.Add (new Vector3(43,-201, 0));
			posList.Add (new Vector3 (145,-16, 0));
			posList.Add (new Vector3 (352,-81, 0));
			posList.Add (new Vector3 (247,144, 0));
			posList.Add (new Vector3 (-69,110, 0));
			posList.Add (new Vector3 (-284,61, 0));
			posList.Add (new Vector3 (-352,-164, 0));
			posList.Add (new Vector3 (-131,-76, 0));
		}

		if(wordLength == 9){
			posList.Add (new Vector3(138,6, 0));
			posList.Add (new Vector3 (327,144, 0));
			posList.Add (new Vector3 (352,-81, 0));
			posList.Add (new Vector3 (181,-201, 0));
			posList.Add (new Vector3 (0,138, 0));
			posList.Add (new Vector3 (-33,-129, 0));
			posList.Add (new Vector3 (-208,-25, 0));
			posList.Add (new Vector3 (-204,141, 0));
			posList.Add (new Vector3 (-352,-164, 0));
		}

		if(wordLength == 10){
			posList.Add (new Vector3(-328,-194, 0));
			posList.Add (new Vector3 (-337,113, 0));
			posList.Add (new Vector3 (-281,-31, 0));
			posList.Add (new Vector3 (312,144, 0));
			posList.Add (new Vector3 (242,-201, 0));
			posList.Add (new Vector3 (352,-81, 0));
			posList.Add (new Vector3 (41,148, 0));
			posList.Add (new Vector3 (-109,9, 0));
			posList.Add (new Vector3 (-73,-170, 0));
			posList.Add (new Vector3 (74,-52, 0));
		}

		if(wordLength == 11){
			posList.Add (new Vector3(-328,-194, 0));
			posList.Add (new Vector3 (-337,113, 0));
			posList.Add (new Vector3 (-281,-31, 0));
			posList.Add (new Vector3 (312,144, 0));
			posList.Add (new Vector3 (242,-201, 0));
			posList.Add (new Vector3 (208,42, 0));
			posList.Add (new Vector3 (352,-81, 0));
			posList.Add (new Vector3 (41,148, 0));
			posList.Add (new Vector3 (-109,9, 0));
			posList.Add (new Vector3 (-73,-170, 0));
			posList.Add (new Vector3 (74,-52, 0));
		}

		for (int i = 0; i < posList.Count; i++) {
			//image作成
			createImage = Instantiate(moji, posList[i], Quaternion.identity) as GameObject;
			listMoji.Add (createImage);
			createImage.transform.SetParent(canvas.transform, false);
			createImage.transform.SetSiblingIndex(0);
		}
			
		//print ("created listmojiCount = " + listMoji.Count);


	}

	void ClearLine(){
		dateManager = DateManager.Instance;
		string clear = dateManager.stageId.ToString() + "-" + dateManager.levelId.ToString();

		if(clear == "1-1"){
			clearLineText.text = "7";
			dateManager.clearLine = 7;
		}else if((clear == "1-2")||(clear == "1-3")){
			clearLineText.text = "10";
			dateManager.clearLine = 10;
		}else if((clear == "6-3")||(clear == "3-2")){
			clearLineText.text = "13";
			dateManager.clearLine = 13;
		}else if((clear == "3-1")||(clear == "4-1")||(clear == "5-1")||(clear == "5-2")||(clear == "6-1")||(clear == "6-2")||(clear == "7-2")||(clear == "7-3")){
			clearLineText.text = "15";
			dateManager.clearLine = 15;
		}else if(clear == "7-1"){
			clearLineText.text = "20";
			dateManager.clearLine = 20;
		}else {
			clearLineText.text = "12";
			dateManager.clearLine = 12;
		}

	}

	void Awake () {
		dateManager = DateManager.Instance;
	}


	// Use this for initialization
	void Start () {

		init ();
		stageImages ();
		HintIcon ();
		ClearLine ();

	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)){
			

			Vector3 screenPos = Input.mousePosition;
			Vector3 worldPos = Camera.main.ScreenToWorldPoint (screenPos);
			//worldPos.z = -1;
			//Debug.Log ("worldPos = " + worldPos);
			Vector2 tapPoint = new Vector2 (worldPos.x, worldPos.y);
			Collider2D col2d = Physics2D.OverlapPoint (tapPoint);
			if(col2d){
				RaycastHit2D hitObj = Physics2D.Raycast (tapPoint, -Vector2.up);
				//print (hitObj);
				if(hitObj){
					string name = LayerMask.LayerToName (col2d.gameObject.layer);
					if(name == "Moji"){
						CollectedText.text = "";
						isCollectMoji = true;
						isTouchMoji = true;
					}
				}
			}
		}


		if(Input.GetMouseButtonUp(0)){
			
			if(!isColectedAllMoji ()){
				foreach(GameObject hitCircle in listHitCircle ){
					buttonImage_ =  hitCircle.GetComponent<Image> ();
					buttonImage_.sprite = setMaruImages;
				}
			}
			//回収したidのチェック
			if(CheckCollectedMojiId()){
				if(dateManager.tutrial == "false"){
					dateManager.tutrial = "true";
					dateManager.UpdateSaveDate ();
					GameObject fg = GameObject.Find("finger");
					Destroy (fg);
				}

				dateManager.SetDataToDic (dateManager.stageId, checkWord);

				AudioPlayer.PlaySe("Sounds/SE/Correct_20160209");
				lineRendererManager.GetComponent<CircularTest> ().stop = true;
				StartCoroutine (CollectEffect ());


				//CollectedText.text = "正解！";

				//正解の数をカウント
				collectCount++;
				currentClearText.text = collectCount.ToString ();

				dateManager = DateManager.Instance;
				dateManager.collectCount = collectCount;
				//clear = true;

				//recet.GetComponent<SceneManager1>().RecetWord();
				//ShuffleMojiIds ();
			}
			isCollectMoji = false;
		}

		if(isCollectMoji){
			CheckHitMoji ();
		}

	}

	public bool isColectedAllMoji () {
		if(listCollectedMojiId.Count < mojis.Length){
			return false;
		}
		return true;
	}

	bool CheckCollectedMojiId(){
		//数は十分か
		if(listCollectedMojiId.Count < mojis.Length){
			listCollectedMojiId.Clear ();
			return false;
		}
		//回収したIDは順番通りか
		bool isClear = true;
		//for (int i = 0; i < listCollectedMojiId.Count; i++){

		if(CollectedText.text != checkWord){
			if(dateManager.tutrial == "false"){
				dateManager.tutrial = "true";
				dateManager.UpdateSaveDate ();
				GameObject fg = GameObject.Find("finger");
				Destroy (fg);
			}
			AudioPlayer.PlaySe("Sounds/SE/Incorrect_20160119");
			StartCoroutine (InCollectEffect());
			lineRendererManager.GetComponent<CircularTest> ().stop = true;
			//CollectedText.text = "不正解";

				//不正解の数をカウント
				missCount++;

				dateManager = DateManager.Instance;
				dateManager.missCount = missCount;

				//unClear = true;
				//recet.GetComponent<SceneManager1>().RecetWord();
				//ShuffleMojiIds ();
				isClear = false;
			}
		//}
		listCollectedMojiId.Clear ();
		return isClear;
	}

	//文字IDを回収していく関数
	void CheckHitMoji(){
		Vector3 screenPos = Input.mousePosition;
		Vector3 worldPos = Camera.main.ScreenToWorldPoint (screenPos);

		int mask = 1 << LayerMask.NameToLayer ("Moji");
		Collider2D col = Physics2D.OverlapPoint (worldPos, mask);

		if(col){
			GameObject obj = col.gameObject;
			prevTouchMoji = obj;
			isTouchMoji = true;
			//回収したIDの重複チェック、重複がない場合のみリストに格納
			if(CheckOverLap(obj.GetComponent<Moji>().myId) == false){
				listCollectedMojiId.Add(obj.GetComponent<Moji>().myId);
				char c = obj.GetComponent<Moji> ().myChar;
				CollectedText.text += c.ToString ();

				//触れた時の画像に変える
				buttonImage_ = col.gameObject.GetComponent<Image> ();
				buttonImage_.sprite = setMaru3Images;
				listHitCircle.Add(col.gameObject);

				tapSE.GetComponent<PlayAudio> ().TapSE();

				lineRendererManager.GetComponent<CircularTest> ().HitMoji (col.gameObject.transform.position);


			}
		}else if(isTouchMoji == true){
			buttonImage_ = prevTouchMoji.gameObject.GetComponent<Image> ();
			buttonImage_.sprite = setMaru2Images;
			isTouchMoji = false;
		}
	}



	bool CheckOverLap(int targetId){
		foreach(int id in listCollectedMojiId){
			if(id == targetId){
				return true;
			}
		
		}
		return false;
	}

	void ShuffleMojiIds () {
		int n = mojiIds.Length;
		System.Random rdm = new System.Random ();
		if(dateManager.tutrial != "false"){
			while (n > 1) {
				n--;
				int k = rdm.Next(n + 1);
				int tmp = mojiIds[k];
				mojiIds[k] = mojiIds[n];
				mojiIds[n] = tmp;
			}
		}
		listCollectedMojiId = new List<int>();
		for(int i = 0; i < mojiIds.Length; i++){
			GameObject moji = listMoji [i];
			int mojiId = mojiIds [i];
			moji.GetComponent<Moji> ().Init (mojiId, mojis [mojiId]);
			moji.name = mojis [mojiId].ToString();
		}
	}



	void giveHint(string word){
		
		hintText.text = hint.GetComponent<HintManager>().hintDic[word];
	}




	public void PausePanel(){
		//ポーズ画面作成
		Vector3 PanelPos = new Vector3 (-50f, 50f, 0f);

		var createPause = Instantiate(panel, PanelPos, Quaternion.identity) as GameObject;
		createPause.transform.SetParent(canvas.transform, false);
	}

	IEnumerator CollectEffect(){
		
		judgeCollect.SetActive (true);

		yield return new WaitForSeconds (1);
		lineRendererManager.GetComponent<CircularTest> ().InitLine();

		foreach(GameObject hitCircle in listHitCircle ){
			buttonImage_ =  hitCircle.GetComponent<Image> ();
			buttonImage_.sprite = setMaruImages;
		}
		listHitCircle.Clear ();

		judgeCollect.SetActive (false);

		recet.GetComponent<SceneManager1>().RecetWord();

		/*
		Vector3 targetPos = new Vector3 (4.42f, 1.9f, 0.0f);
		iTween.MoveTo(star,iTween.Hash (
		"position", targetPos,
		"time", 1.0f,
		"islocal",true,
		"oncompletetarget",this.gameObject,
		"easetype",iTween.EaseType.easeOutQuart));
		*/
	}

	IEnumerator InCollectEffect(){
		judgeInCollect.SetActive (true);

		yield return new WaitForSeconds (1);
		lineRendererManager.GetComponent<CircularTest> ().InitLine();

		foreach(GameObject hitCircle in listHitCircle ){
			buttonImage_ =  hitCircle.GetComponent<Image> ();
			buttonImage_.sprite = setMaruImages;
		}

		listHitCircle.Clear ();

		judgeInCollect.SetActive (false);

		recet.GetComponent<SceneManager1>().RecetWord();
	}
}

