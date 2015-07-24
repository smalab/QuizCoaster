using UnityEngine;
using System.Collections;

public class appearexit : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Appearance(){
		//anim.SetTrigger ("appearance");
		anim.SetBool ("appearanceexit", true);
	}

	public void Exit(){
		//anim.SetTrigger ("exit");
		anim.SetBool ("appearanceexit", false);
	}
}
