using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scorecenter : MonoBehaviour {

	private Animator anim;
	public Text score;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Center(){
		anim.SetTrigger ("center");
		score.resizeTextMaxSize = 50;
	}
}
