using UnityEngine;
using System.Collections;
using System;

public class test : MonoBehaviour {

	DateManager dateManager;
	public GameObject finger;

	// Use this for initialization
	void Start () {
		dateManager = DateManager.Instance;
		if (dateManager.tutrial == "false") {
		
			Vector3 targetPos = new Vector3 (190.0f, -200.0f, 0.0f);
			iTween.MoveTo (finger, iTween.Hash (
				"position", targetPos,
				"time", 1.5f,
				"islocal", true,
				"oncompletetarget", this.gameObject,
				"easetype", iTween.EaseType.easeOutQuart,
				"loopType", "loop"));
			
		}else{
			finger.SetActive (false);
		}
		/*
		int[] TestArray = new int[5];
		Array.Resize (ref TestArray, 8);

		for (int i = 0; i < TestArray.Length; i++) {
			TestArray [i] = i;
			print (TestArray [i]);
		}

		//PrintHello (3);
		//PrintHello (6);
		//PrintHello (13);
		*/
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
