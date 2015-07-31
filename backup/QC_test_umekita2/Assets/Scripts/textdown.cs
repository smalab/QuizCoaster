using UnityEngine;
using System.Collections;

public class textdown : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void down(){
		anim.SetTrigger ("down");
	}
}
