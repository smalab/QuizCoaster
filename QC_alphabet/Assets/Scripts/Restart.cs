using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	public static string homebutton;
	Scorecontroller Scorecontroller;

	void Start() {
		Scorecontroller = gameObject.GetComponent<Scorecontroller> ();
	}
	public void Update(){
		if(homebutton == "Home"){
			Scorecontroller.Restscore();
		Application.LoadLevel ("Start");
	}
}
}
