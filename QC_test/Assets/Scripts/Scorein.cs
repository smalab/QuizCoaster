using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scorein : MonoBehaviour {

	public Text score;

	// Use this for initialization
	void Start () {
		score.text = Scorecontroller.score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
