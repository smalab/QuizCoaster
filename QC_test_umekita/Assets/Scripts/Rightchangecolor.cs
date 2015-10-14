using UnityEngine;
using System.Collections;

public class Rightchangecolor : MonoBehaviour {

	public static Renderer cursorcolor;
	private static Color green = new Color (79f / 255f, 227f / 255f, 20f / 255f, 1f);
	private static Color yellow = new Color (246f / 255f, 1f, 96f / 255, 1f);
	private static Color red = new Color (1f, 0f, 0f, 1f);

	// Use this for initialization
	void Start () {
		cursorcolor = GetComponent<Renderer> ();
		// scube.material.color = Color.red;
		//GetComponent<Renderer> ().material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static void Changered(){
		cursorcolor.material.color  = Color.red;
	}

	public static void Changeyellow(){
		//GetComponent<Renderer>().material.color = yellow;
		cursorcolor.material.color = yellow;
	}

	public static void Changegreen(){
		//GetComponent<Renderer>().material.color = green;
		cursorcolor.material.color = green;
	}
	
	public static void Enabled(){
		cursorcolor.enabled = true;
	}

	public static void Disabled(){
		cursorcolor.enabled = false;
	}
}
