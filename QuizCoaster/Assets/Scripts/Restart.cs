using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	Scorecontroller Scorecontroller;
	ScreenRaycast ScreenRaycast;

	void Start() {
		Scorecontroller = gameObject.GetComponent<Scorecontroller> ();
		ScreenRaycast = GetComponent<ScreenRaycast> ();
	}
	void Update(){
		if(ScreenRaycast.hitname == "Home"){
			Debug.Log ("homebutton == Home");
			Scorecontroller.Restscore();
		Application.LoadLevel ("DifficultyLevelSelection");
	}
}
}
