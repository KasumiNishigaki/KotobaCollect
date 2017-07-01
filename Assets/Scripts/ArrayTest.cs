using UnityEngine;
using System.Collections;
using System.Collections.Generic;

class QuizDetail{
	public string content = "";
	public bool isClear = false;
}


public class ArrayTest : MonoBehaviour {

	DateManager dateManager;
	List<int> listMyId;


	private int stageId = 1;
	private int levelId = 1;

	Dictionary<string, List<QuizDetail>> dicQuiz = new Dictionary<string, List<QuizDetail>> ();


	//Dictionary<>

	// Use this for initialization
	void Start () {
		//print ("listMyId = " + listMyId);
		//listMyId = new List<int> ();
		/*
		dateManager = DateManager.Instance;

		List<QuizDetail> quiz1_1 = new List<QuizDetail> ();
		QuizDetail q1 = new QuizDetail ();
		QuizDetail q2 = new QuizDetail ();
		QuizDetail q3 = new QuizDetail ();
		q1.content = "あああ";
		q2.content = "いいい";
		q3.content = "ううう";
		quiz1_1.Add (q1);
		quiz1_1.Add (q2);
		quiz1_1.Add (q3);

		dicQuiz.Add ("1-1", quiz1_1);


	

		string key = stageId.ToString() + "-" + levelId.ToString();

		print (key);

		if(dicQuiz.ContainsKey (key)){
			List<QuizDetail> list = dicQuiz [key];
			foreach(QuizDetail qd in list){
				print ("qd = " + qd.content);
			}
		}else{
			print("キーがありません");
		}
		*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*
	public void OnClickDetail(){
		int stageId = 1;
		int levelId = 2;

		string key = stageId.ToString() + "-" + levelId.ToString;

		if(dicQuiz.ContainsKey (key)){
			List<QuizDetail> list = dicQuiz [key];
			foreach(QuizDetail qd in list){
				print ("qd = " + qd.content);
			}
		}else{
			print("キーがありません");
		}
	}*/
}
