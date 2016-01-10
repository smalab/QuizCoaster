using UnityEngine;
using System.Collections;

public class Startbutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Pushstart(){
		Debug.Log ("*****push******");
		Application.LoadLevel ("explain");
	}
}
