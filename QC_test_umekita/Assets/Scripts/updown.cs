using UnityEngine;
using System.Collections;

public class updown : MonoBehaviour {

	Animator anim;
	private float time;
	// Use this for initialization
	void Start () {
		time = 0.0f;
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((time % 1.0f) / 2.0f < 0.25f) {
			anim.SetTrigger ("up");
			/*if (time % 1.0f >= 0.5f)*/
		} else {
			anim.SetTrigger ("down");
		}
		time += Time.deltaTime;
	}
}
