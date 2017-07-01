using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Moji : MonoBehaviour {

	public Text mojiText;

	int _myId;
	public int myId{
		get { return _myId; }
		set { _myId = value; }
	}

	char _myChar;
	public char myChar{
		get { return _myChar; }
		set { _myChar = value; }
	}

	public void Init(int myId, char myChar){
		_myId = myId;
		_myChar = myChar;

		mojiText.text = _myChar.ToString ();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
