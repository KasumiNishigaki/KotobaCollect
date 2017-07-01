using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class CircularTest : MonoBehaviour {

	public MojiCollectManager mojiCollectManager;

	public Image circularImage;
	public Material material;

	public GameObject timerBg;
	public List<Sprite> timerImages;

	float totalTime = 60.0f;// ゲーム時間仮に10秒
	float lastTime;
	bool alarm = true;
	public bool stop = false;

	LineRenderer line;
	List<LineRenderer> lines = new List<LineRenderer> ();

	public GameObject tapSE;

	int currentLines = 0;
	Vector3 mousePos;

	// Use this for initialization
	void Start () {
		totalTime = 60.0f;
		lastTime = totalTime;
	}
		
	
	// Update is called once per frame
	void Update () {
		lastTime -= Time.deltaTime;
		float ratio = 1.0f - (lastTime / totalTime);
		if (ratio > 1.0f)
			ratio = 0.0f;
		circularImage.fillAmount = ratio;


		if ((lastTime <= 15)&&(alarm == true)) {
			AudioPlayer.PlaySe ("Sounds/SE/Alarm20160121");
			alarm = false;
		}

		ChangeTimerColor ();

		if (Input.GetMouseButtonDown (0)){
			mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mousePos.z = 0;

		}
		else if((Input.GetMouseButtonUp (0)) && mojiCollectManager.isColectedAllMoji ()){
			//StartCoroutine (Effect());
			//print("止まる");
	
		}
		else if ((Input.GetMouseButtonUp (0))&&(stop == false) && line){
			mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mousePos.z = 0;
			line.SetPosition (1, mousePos);

			//Destroy (GameObject.Find("Line" + currentLines));
			Destroy(line.gameObject);

			line = null;
			currentLines++;

			// ラインを全削除.
			foreach (LineRenderer l in lines) {
				Destroy (l.gameObject);
			}

			tapSE.GetComponent<PlayAudio> ().init();

			lines = new List<LineRenderer> ();
			stop = false;
		}
		else if (Input.GetMouseButton (0) && line) {
			mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			mousePos.z = 0;
			line.SetPosition (1, mousePos);
		}

	}

	public void HitMoji (Vector3 mojiPos) {

		mojiPos.z = 0;

		if(line) line.SetPosition (1, mojiPos);

		line = null;

		if (!mojiCollectManager.isColectedAllMoji ()) {
			line = new GameObject ("Line" + currentLines).AddComponent<LineRenderer> ();

			line.SetVertexCount (2);

			line.material = material;
			line.SetWidth (0.3f, 0.3f);
			line.useWorldSpace = true;

			lines.Add (line);

			line.SetPosition (0, mojiPos);
			line.SetPosition (1, mousePos);
		}
	}


	void ChangeTimerColor () {
		Sprite setImage = timerImages [0];

		if (lastTime <= 15) {
			setImage = timerImages [3];
		} else if (lastTime <= 30) {
			setImage = timerImages [2];
		} else if (lastTime <= 45) {
			setImage = timerImages [1];
		}
			

		if (timerBg.GetComponent<Image> ().sprite != setImage) {
			timerBg.GetComponent<Image> ().sprite = setImage;
		}
	}

	public void InitLine(){
		//mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//mousePos.z = 0;
		//line.SetPosition (1, mousePos);

		//Destroy (GameObject.Find("Line" + currentLines));
		//Destroy(line.gameObject);

		//line = null;
		currentLines++;

		// ラインを全削除.
		foreach (LineRenderer l in lines) {
			Destroy (l.gameObject);
		}

		tapSE.GetComponent<PlayAudio> ().init();

		lines = new List<LineRenderer> ();
		stop = false;
	}
}