using UnityEngine;
using System.Collections;

public class ED : MonoBehaviour {

	private Vector3 m_pos;
	public string nextScene;
	// スクロールするスピード
	public float speed;

	// Use this for initialization
	void Start () {
		m_pos = transform.localPosition;  // 形状位置を保持
	}
	
	// Update is called once per frame
	void Update () {
	
		if(m_pos.x <= -19300.0f){
			
		}else{
			//this.transform.position = new Vector3(x, y, z);
			transform.localPosition = m_pos;  // 形状位置を更新
			m_pos.x += speed;
		}

	}
	/*
	if(m_pos.x <= -20518.0f){

		GameObject ed2 = GameObject.Find("ed2");  // xxxx のGameObjectを取得.
		Vector3 pos = ed2.transform.localPosition;

		if(pos.x <= -6316.0f){
			AudioPlayer.StopBgm();
			Application.LoadLevel (nextScene);
		}

		pos.x += speed;
		ed2.transform.localPosition = pos;

	}

	//this.transform.position = new Vector3(x, y, z);
	transform.localPosition = m_pos;  // 形状位置を更新
	m_pos.x += speed;
	*/
}
