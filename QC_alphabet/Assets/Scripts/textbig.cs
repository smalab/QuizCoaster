using UnityEngine;
using System.Collections;

public class textbig : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void big(){
		anim.SetTrigger ("big");
	}
}
