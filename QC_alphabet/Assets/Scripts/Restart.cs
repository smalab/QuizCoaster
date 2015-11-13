using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	public static string homebutton;
	Scorecontroller Scorecontroller;

	void Start() {
		Scorecontroller = gameObject.GetComponent<Scorecontroller> ();
	}

	void Update(){
		Debug.Log ("InRestart");
		if(homebutton == "Home"){
			Debug.Log("homebutton == Home");
			Scorecontroller.Restscore();
			Application.LoadLevel ("Start");
		}
	}
}
