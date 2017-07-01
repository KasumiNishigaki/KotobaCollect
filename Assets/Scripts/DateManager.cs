using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DateManager : MonoBehaviour {

	const string PLAYER_PREFS_CLEARED_STAGE_ID = "ClearedStageId";
	const string PLAYER_PREFS_CLEARED_LEVEL_ID = "ClearedLevelId";

	const string PLAYER_PREFS_PICTURE_BOOK_1 = "PictureBook1";
	const string PLAYER_PREFS_PICTURE_BOOK_2 = "PictureBook2";
	const string PLAYER_PREFS_PICTURE_BOOK_3 = "PictureBook3";
	const string PLAYER_PREFS_PICTURE_BOOK_4 = "PictureBook4";
	const string PLAYER_PREFS_PICTURE_BOOK_5 = "PictureBook5";
	const string PLAYER_PREFS_PICTURE_BOOK_6 = "PictureBook6";
	const string PLAYER_PREFS_PICTURE_BOOK_7 = "PictureBook7";

	const string PLAYER_PREFS_TUTRIAL = "TUTRIAL";
	const string PLAYER_PREFS_COMPLETE = "COMPLETE";
	const string PLAYER_PREFS_OP = "OP";

	//コンストラクタ(1回だけ使われる、関数と同じ名前)
	private DateManager(){
		Debug.Log("create DateManager instance done");

		//int version = PlayerPrefs.GetInt ("VERSION",1) デフォルト値が欲しい時;
		//getint呼び出す
		int version = PlayerPrefs.GetInt ("VERSION");
		Debug.Log ("version = " + version);

		//値をセット
		PlayerPrefs.SetInt ("VERSION", 4444);

		if(!PlayerPrefs.HasKey("CleardStage")){
			PlayerPrefs.SetInt ("CleardStage", 1);
		}

		if(!PlayerPrefs.HasKey(PLAYER_PREFS_TUTRIAL)){
			PlayerPrefs.SetString (PLAYER_PREFS_TUTRIAL, "false");
			tutrial = "false";
		}

		if(!PlayerPrefs.HasKey(PLAYER_PREFS_COMPLETE)){
			PlayerPrefs.SetString (PLAYER_PREFS_COMPLETE, "false");
			complete = "false";
		}

		if(!PlayerPrefs.HasKey(PLAYER_PREFS_OP)){
			PlayerPrefs.SetString (PLAYER_PREFS_OP, "false");
			op_ = "false";
		}

		//変更された値を保存する
		PlayerPrefs.Save();

		//消したい時
		//PlayerPrefs.DeleteAll();
	}

	//DateManager._instanceというように使えるけどprivateの時は使えない
	//DateManager.Ins

	private static DateManager _instance;
	public static DateManager Instance{
		get{
			if(_instance == null){
				GameObject go = new GameObject ("DateManager");
				_instance = go.AddComponent<DateManager> ();
			}
			//初期化しない/シングルトンだけでつかってあげると良い
			DontDestroyOnLoad (_instance);
			return _instance;
		}
	}

	//public int myScore = 0;
	public int stageId;
	public int levelId;
	public int collectCount;
	public int missCount;
	public int clearedStageId = 1;
	public int clearedLevelId = 0;
	public int clearLine;
	public bool sound_on;
	public string tutrial;
	public string complete;
	public string op_;

	public List<string> pictureBook1 = new List<string>();
	public List<string> pictureBook2 = new List<string>();
	public List<string> pictureBook3 = new List<string>();
	public List<string> pictureBook4 = new List<string>();
	public List<string> pictureBook5 = new List<string>();
	public List<string> pictureBook6 = new List<string>();
	public List<string> pictureBook7 = new List<string>();

	// Use this for initialization
	void Start () {
		//Debug.Log("DateManager :: Start");
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("DateManager :: Update");
	}

	public void LoadSaveDate(){
		if(PlayerPrefs.HasKey (PLAYER_PREFS_CLEARED_STAGE_ID)){
			clearedStageId = PlayerPrefs.GetInt (PLAYER_PREFS_CLEARED_STAGE_ID);
		}

		if(PlayerPrefs.HasKey (PLAYER_PREFS_CLEARED_LEVEL_ID)){
			clearedLevelId = PlayerPrefs.GetInt (PLAYER_PREFS_CLEARED_LEVEL_ID);
		}

		if(PlayerPrefs.HasKey (PLAYER_PREFS_TUTRIAL)){
			tutrial = PlayerPrefs.GetString (PLAYER_PREFS_TUTRIAL);
		}

		if(PlayerPrefs.HasKey (PLAYER_PREFS_COMPLETE)){
			complete = PlayerPrefs.GetString (PLAYER_PREFS_COMPLETE);
		}

		if(PlayerPrefs.HasKey (PLAYER_PREFS_OP)){
			op_ = PlayerPrefs.GetString (PLAYER_PREFS_OP);
		}

		// dic.

		if (PlayerPrefs.HasKey(PLAYER_PREFS_PICTURE_BOOK_1)){
			pictureBook1 = StringToList (PlayerPrefs.GetString (PLAYER_PREFS_PICTURE_BOOK_1));
		}

		if (PlayerPrefs.HasKey(PLAYER_PREFS_PICTURE_BOOK_2)){
			pictureBook2 = StringToList (PlayerPrefs.GetString (PLAYER_PREFS_PICTURE_BOOK_2));
		}

		if (PlayerPrefs.HasKey(PLAYER_PREFS_PICTURE_BOOK_3)){
			pictureBook3 = StringToList (PlayerPrefs.GetString (PLAYER_PREFS_PICTURE_BOOK_3));
		}

		if (PlayerPrefs.HasKey(PLAYER_PREFS_PICTURE_BOOK_4)){
			pictureBook4 = StringToList (PlayerPrefs.GetString (PLAYER_PREFS_PICTURE_BOOK_4));
		}

		if (PlayerPrefs.HasKey(PLAYER_PREFS_PICTURE_BOOK_5)){
			pictureBook5 = StringToList (PlayerPrefs.GetString (PLAYER_PREFS_PICTURE_BOOK_5));
		}

		if (PlayerPrefs.HasKey(PLAYER_PREFS_PICTURE_BOOK_6)){
			pictureBook6 = StringToList (PlayerPrefs.GetString (PLAYER_PREFS_PICTURE_BOOK_6));
		}

		if (PlayerPrefs.HasKey(PLAYER_PREFS_PICTURE_BOOK_7)){
			pictureBook7 = StringToList (PlayerPrefs.GetString (PLAYER_PREFS_PICTURE_BOOK_7));
		}

	}

	public void UpdateSaveDate(){
		PlayerPrefs.SetInt (PLAYER_PREFS_CLEARED_STAGE_ID, clearedStageId);
		PlayerPrefs.SetInt (PLAYER_PREFS_CLEARED_LEVEL_ID, clearedLevelId);
		PlayerPrefs.SetString (PLAYER_PREFS_TUTRIAL, tutrial);
		PlayerPrefs.SetString (PLAYER_PREFS_COMPLETE, complete);
		PlayerPrefs.SetString (PLAYER_PREFS_OP, op_);

		// dic.
		PlayerPrefs.SetString (PLAYER_PREFS_PICTURE_BOOK_1, ListToString (pictureBook1));
		PlayerPrefs.SetString (PLAYER_PREFS_PICTURE_BOOK_2, ListToString (pictureBook2));
		PlayerPrefs.SetString (PLAYER_PREFS_PICTURE_BOOK_3, ListToString (pictureBook3));
		PlayerPrefs.SetString (PLAYER_PREFS_PICTURE_BOOK_4, ListToString (pictureBook4));
		PlayerPrefs.SetString (PLAYER_PREFS_PICTURE_BOOK_5, ListToString (pictureBook5));
		PlayerPrefs.SetString (PLAYER_PREFS_PICTURE_BOOK_6, ListToString (pictureBook6));
		PlayerPrefs.SetString (PLAYER_PREFS_PICTURE_BOOK_7, ListToString (pictureBook7));

		PlayerPrefs.Save ();
	}

	string ListToString (List<string> list) {
		var str = "";

		if (list.Count != 0) {
			foreach (var l in list) {
				print (l);
				str += l + ",";
			}
			str = str.Substring (0, str.Length - 1);	
		}

		return str;
	}

	List<string> StringToList (string str) {
		List<string> list = new List<string> ();

		string[] strs = str.Split (new char[] {','});

		foreach (var s in strs) {
			list.Add (s);
		}

		return list;
	}

	public void SetDataToDic (int _stageId, string data) {
		print (_stageId);
		print (data);
		if (_stageId == 1) {
			if (!pictureBook1.Contains (data)) {
				pictureBook1.Add (data);
			}
		} else if (_stageId == 2) {
			if (!pictureBook2.Contains (data)) {
				pictureBook2.Add (data);
			}
		} else if (_stageId == 3) {
			if (!pictureBook3.Contains (data)) {
				pictureBook3.Add (data);
			}
		} else if (_stageId == 4) {
			if (!pictureBook4.Contains (data)) {
				pictureBook4.Add (data);
			}
		} else if (_stageId == 5) {
			if (!pictureBook5.Contains (data)) {
				pictureBook5.Add (data);
			}
		} else if (_stageId == 6) {
			if (!pictureBook6.Contains (data)) {
				pictureBook6.Add (data);
			}
		} else if (_stageId == 7) {
			if (!pictureBook7.Contains (data)) {
				pictureBook7.Add (data);
			}
		}

		UpdateSaveDate ();
	}

	public bool HasDataList (int _stageId, string data) {
		if (_stageId == 1) {
			return pictureBook1.Contains (data);
		} else if (_stageId == 2) {
			return pictureBook2.Contains (data);
		} else if (_stageId == 3) {
			return pictureBook3.Contains (data);
		} else if (_stageId == 4) {
			return pictureBook4.Contains (data);
		} else if (_stageId == 5) {
			return pictureBook5.Contains (data);
		} else if (_stageId == 6) {
			return pictureBook6.Contains (data);
		} else if (_stageId == 7) {
			return pictureBook7.Contains (data);
		}
		return false;
	}
}