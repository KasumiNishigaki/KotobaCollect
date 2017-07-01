using UnityEngine;
using System.Collections;

public class OP : MonoBehaviour {
	DateManager dateManager;
	private Vector3 m_pos;
	public string nextScene;
	// スクロールするスピード
	public float speed;

	// Use this for initialization
	void Start () {
		dateManager = DateManager.Instance;
		dateManager.op_ = "true";
		dateManager.UpdateSaveDate ();
		m_pos = transform.localPosition;  // 形状位置を保持
	}
	
	// Update is called once per frame
	void Update () {

		if(m_pos.x <= -12855.0f){
			AudioPlayer.StopBgm();
			Application.LoadLevel (nextScene);
		}
	
		//this.transform.position = new Vector3(x, y, z);
		transform.localPosition = m_pos;  // 形状位置を更新
		m_pos.x += speed;



	}


}
