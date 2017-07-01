using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class StorySceneManager : MonoBehaviour {

	DateManager dateManager;

	public GameObject bgImage;
	public List<Sprite> bgImages;
	public GameObject storyImage;
	public List<Sprite> storyImages;
	public GameObject stageNameImage;
	public List<Sprite> stageNameImages;
	public GameObject levelImage;
	public List<Sprite> levelImages;

	public GameObject story;
	public Text storyText;
	public Text storyText2;
	// Use this for initialization
	void Start () {
		StoryImages ();
		ChangeBg ();
		ChangeLevel ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChangeLevel(){
		dateManager = DateManager.Instance;
		int level = dateManager.levelId;

		Sprite setLevel = levelImages [0];

		if(level == 1){
			setLevel = levelImages [0];
		}else if(level == 2){
			setLevel = levelImages [1];
		}else if(level == 3){
			setLevel = levelImages [2];
		}

		levelImage.GetComponent<Image> ().sprite = setLevel;
	}

	public void ChangeBg(){
		dateManager = DateManager.Instance;
		int stage = dateManager.stageId;

		Sprite setBg = bgImages [0];
		Sprite setStage = stageNameImages [0];

		if(stage == 1){
			setBg = bgImages [0];
			setStage = stageNameImages [0];
		}else if(stage == 2){
			setBg = bgImages [1];
			setStage = stageNameImages [1];
		}else if(stage == 3){
			setBg = bgImages [2];
			setStage = stageNameImages [2];
		}else if(stage == 4){
			setBg = bgImages [3];
			setStage = stageNameImages [3];
		}else if(stage == 5){
			setBg = bgImages [4];
			setStage = stageNameImages [4];
		}else if(stage == 6){
			setBg = bgImages [5];
			setStage = stageNameImages [5];
		}else if(stage == 7){
			setBg = bgImages [6];
			setStage = stageNameImages [6];
		}

		bgImage.GetComponent<Image> ().sprite = setBg;
		stageNameImage.GetComponent<Image> ().sprite = setStage;
	}

	public void StoryImages(){
		dateManager = DateManager.Instance;
		string key = dateManager.stageId.ToString() + "-" + dateManager.levelId.ToString();

		Sprite setStory = storyImages [0];

		if (key == "1-1") {
			setStory = storyImages [0];
			storyText2.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "1-2"){
			setStory = storyImages [1];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "1-3"){
			setStory = storyImages [2];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "2-1"){
			setStory = storyImages [3];
			storyText2.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "2-2"){
			setStory = storyImages [4];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "2-3"){
			setStory = storyImages [5];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "3-1"){
			setStory = storyImages [6];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "3-2"){
			setStory = storyImages [7];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "3-3"){
			setStory = storyImages [8];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "4-1") {
			setStory = storyImages [9];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "4-2"){
			setStory = storyImages [10];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "4-3"){
			setStory = storyImages [11];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "5-1"){
			setStory = storyImages [12];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "5-2"){
			setStory = storyImages [13];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "5-3"){
			setStory = storyImages [14];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "6-1"){
			setStory = storyImages [15];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "6-2"){
			setStory = storyImages [16];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "6-3"){
			setStory = storyImages [17];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "7-1"){
			setStory = storyImages [18];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "7-2"){
			setStory = storyImages [19];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}else if (key == "7-3"){
			setStory = storyImages [20];
			storyText.text = story.GetComponent<StoryManager>().storyDic[key];
		}

		storyImage.GetComponent<Image> ().sprite = setStory;
	} 
}
