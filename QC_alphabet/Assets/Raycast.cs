using UnityEngine;
using System.Collections;

public class Raycast : MonoBehaviour {
	IOnScreenCollide _OnScreenCollide;
	//Gamestart Gamestart;
	//public static string hit2;
	public static string hit3;
	
	void Start(){
		//Gamestart = gameObject.GetComponent<Gamestart> ();
	}
	
	public void Initialize(IOnScreenCollide _OnScreenCollide){
		if (_OnScreenCollide == null) {
			throw new UnityException ("_OnScreenCollide is null");
		}
		this._OnScreenCollide = _OnScreenCollide;
	}
	
	void Update () {
		string hit2 = _OnScreenCollide.GetRaycastHitTag(transform);
		hit3 = hit2;
		if (hit2 != null) {
			Debug.Log ("in");
			/*if (hit == "right") {
				Debug.Log ("right");
				GameObject.Find ("right").GetComponent<Renderer> ().material.color = Color.red;
				Gamestart.rightcube = true;*/
			}else{
			Debug.Log ("out");
			/*if (hit == "left") {
				GameObject.Find ("left").GetComponent<Renderer> ().material.color = Color.red;
				Gamestart.leftcube = true;
			}*/
		}
	}
}
