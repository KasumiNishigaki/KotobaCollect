using UnityEngine;
using System.Collections;

public class TitleAnimation : MonoBehaviour {

	private float defaultPosition;

	public float speed;
	public float moveRange;

	private float msTimer; 
	private float second;

	public GameObject textObject; //点滅させたい文字

	//private float nextTime;
	//public float interval = 0.5f; //点滅周期

	bool alpha_1;
	float alpha;
	DateManager dateManager;

	// Use this for initialization
	void Start () {
		defaultPosition = transform.position.y;

		dateManager = DateManager.Instance;
		dateManager.LoadSaveDate ();

		alpha = 1.0f;
		textObject.GetComponent<CanvasRenderer> ().SetAlpha (alpha);
		//nextTime = Time.time;
	}
	// Update is called once per frame
	void Update () {

		msTimer += Time.deltaTime;
		second = Mathf.Round (msTimer);

		if(second >= 60){
			Application.LoadLevel ("OP");
		}

		transform.position = new Vector3(transform.position.x, Mathf.Sin(Time.time * speed) * moveRange + defaultPosition, transform.position.z);

		//一定時間ごとに点滅
		//if ( Time.time > nextTime ) {
		//nextTime += interval;

		if (alpha_1 == true){
			if(textObject.GetComponent<CanvasRenderer>().GetAlpha() >= 1.0f){
				alpha_1 = false;
			}
			alpha += 0.01f; 
			textObject.GetComponent<CanvasRenderer>().SetAlpha(alpha);
		}else{
			if(textObject.GetComponent<CanvasRenderer>().GetAlpha() <= 0.0f){
				alpha_1 = true;
			}
			alpha += -0.01f; 
			textObject.GetComponent<CanvasRenderer>().SetAlpha(alpha);
		}

	}

}
