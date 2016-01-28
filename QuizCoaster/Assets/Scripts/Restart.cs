using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	Scorecontroller Scorecontroller;
	ScreenRaycast ScreenRaycast;
	GameObject Informationadd;

	void Start() {
		Scorecontroller = gameObject.GetComponent<Scorecontroller> ();
		ScreenRaycast = GetComponent<ScreenRaycast> ();
		Informationadd = GameObject.Find ("Informationadd");
	}
	void Update(){
		if(ScreenRaycast.hitname == "Home"){
			Debug.Log ("homebutton == Home");
			Scorecontroller.Restscore();
			Destroy(Informationadd);
		Application.LoadLevel ("DifficultyLevelSelection");
	}
}
}
