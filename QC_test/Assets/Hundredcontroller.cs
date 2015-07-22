using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hundredcontroller : MonoBehaviour {

	//public Text hundred;

	// Use this for initialization
	void Start () {
		//GameObject.Find ("hundred").GetComponent<Text>().text = " +100";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void up(){
		Debug.Log ("up");
		GameObject hundred = GameObject.Find ("hundred");
		Renderer hun = hundred.GetComponent<Renderer>();
		hun.enabled = true;
	}

	public static void down(){
		Debug.Log ("down");
		GameObject hundred = GameObject.Find ("hundred");
		Renderer hun = hundred.GetComponent<Renderer>();
		hun.enabled = false;
	}
}
