using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scoreaddtext : MonoBehaviour {

	public Text s;
	Score Score;
	// Use this for initialization
	void Start () {
		Score = GetComponent<Score> ();
		//s.text = s.text + Score.score.ToString;
		GameObject.Find ("scoretext").GetComponent<Text>().text = "Score ";
		GameObject scoretext = GameObject.Find ("scoretext");
		string temp = scoretext.GetComponent<Text>().text;
		temp += Score.score.ToString();
		scoretext.GetComponent<Text> ().text = temp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
