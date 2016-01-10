using UnityEngine;
using System.Collections;

public class BalloonScaling : MonoBehaviour {

	private float time;
	public static Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}

	public static void Scaling(){
		anim.SetTrigger ("scaling");
	}
}
