using UnityEngine;
using System.Collections;

public class FadeScript : MonoBehaviour {

	public string nextScene;

	// Use this for initialization
	void Start () {
		//2秒後にFadeIn()を呼び出す
		//Invoke ("FadeIn", 2f);
		print("フェードイン");
		//iTween.ValueTo(gameObject, iTween.Hash("from", 0f, "to", 1f, "time", 1f, "onupdate", "SetValue"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Fade(){
		//Invoke ("FadeOut", 5f);
	}

	public void FadeIn() {
		// SetValue()を毎フレーム呼び出して、１秒間に０から１までの値の中間値を渡す
		iTween.ValueTo(gameObject, iTween.Hash("from", 0f, "to", 1f, "time", 1f, "onupdate", "SetValue"));
	}
	public void FadeOut() {
		// SetValue()を毎フレーム呼び出して、１秒間に１から０までの値の中間値を渡す
		print("フェードアウト");
		iTween.ValueTo(gameObject, iTween.Hash("from", 1f, "to", 0f, "time", 1f, "onupdate", "SetValue","oncomplete","EndAction",
			"oncompletetarget",gameObject));
	}
	void SetValue(float alpha) {
		// iTweenで呼ばれたら、受け取った値をImageのアルファ値にセット
		gameObject.GetComponent<UnityEngine.UI.Image>().color = new Color(0,0,0, alpha);
	}

	public void EndAction(){
		Debug.Log("end");
		Application.LoadLevel (nextScene);
	}
}
