using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movepushscene : MonoBehaviour {

	public Text passwordtext;
	public Text wrongtext;

	// Use this for initialization
	void Start () {
		wrongtext.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Move(){
		if (passwordtext.text == "sumarabo") {
			wrongtext.enabled = false;
			Destroy (GameObject.Find ("BGM"));
			Destroy (GameObject.Find ("Informationadd"));
			Application.LoadLevel ("Datapush");
		} else {
			wrongtext.enabled = true;
		}
	}
}
