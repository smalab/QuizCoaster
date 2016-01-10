using UnityEngine;
using System.Collections;

public class BalloonChange : MonoBehaviour {

	public GameObject word;
	string difficulty = "なんいどを頭を動\nかしてえらんでね";
	string answer = "本当にそのなんい\nどでいいですか？";
	string go = "行ってらっしゃい!";
	DifficultyCursor DifficultyCursor;

	// Use this for initialization
	void Start () {
		DifficultyCursor = GetComponent<DifficultyCursor> ();
		word.GetComponent<TextMesh>().text = difficulty;
	}
	
	// Update is called once per frame
	void Update () {
		if (DifficultyCursor.changeflag == true) {
			if (DifficultyCursor.rank() == "difficulty")
				word.GetComponent<TextMesh> ().text = difficulty;
			if (DifficultyCursor.rank() == "answer")
				word.GetComponent<TextMesh> ().text = answer;
			if (DifficultyCursor.rank() == "go")
				word.GetComponent<TextMesh> ().text = go;
		}
	}
}
