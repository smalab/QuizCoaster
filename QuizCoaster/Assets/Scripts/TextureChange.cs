using UnityEngine;
using System.Collections;

public class TextureChange : MonoBehaviour {

	ScreenRaycast ScreenRaycast;
	DifficultyCursor DifficultyCursor; 
	GameObject left;
	GameObject right;
	string Left_TEXTURE = "Difficulty/";
	string Right_TEXTURE = "Difficulty/";
	Texture2D Left_Image;
	Texture2D Right_Image;

	// Use this for initialization
	void Start () {
		left = GameObject.Find ("leftplane");
		right = GameObject.Find ("rightplane");
		ScreenRaycast = GetComponent<ScreenRaycast> ();
		DifficultyCursor = GetComponent<DifficultyCursor>();
	}
	
	// Update is called once per frame
	void Update () {
		if (DifficultyCursor.rank () == "difficulty") {
			Left_Image = Resources.Load(Left_TEXTURE + "easy") as Texture2D;
			Right_Image = Resources.Load(Right_TEXTURE + "hard") as Texture2D;
			left.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = Left_Image;
			right.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = Right_Image;
			left.tag = "easy";
			right.tag = "hard";
		}
		if (DifficultyCursor.rank () == "answer") {
			Left_Image = Resources.Load(Left_TEXTURE + "yes") as Texture2D;
			Right_Image = Resources.Load(Right_TEXTURE + "no") as Texture2D;
			left.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = Left_Image;
			right.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = Right_Image;
			left.tag = "yes";
			right.tag = "no";
		}
	}
}
