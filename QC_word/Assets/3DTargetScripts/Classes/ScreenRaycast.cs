using UnityEngine;
using System.Collections;

public class ScreenRaycast : MonoBehaviour {
	IOnScreenCollide _OnScreenCollide;
	Gamestart Gamestart;
	cursor cursor;
	Restart Restart;

	void Start(){
		Gamestart = gameObject.GetComponent<Gamestart> ();
		cursor = gameObject.GetComponent<cursor> ();
		Restart = gameObject.GetComponent<Restart> ();

	}

	public void Initialize(IOnScreenCollide _OnScreenCollide){
		if (_OnScreenCollide == null) {
			throw new UnityException ("_OnScreenCollide is null");
		}
		this._OnScreenCollide = _OnScreenCollide;
	}

	void Update () {
		string hit = _OnScreenCollide.GetRaycastHitName(transform);
		cursor.whichcursor = hit;
		Restart.homebutton = hit;

		if (hit != null) {
			if (hit == "right") {
				GameObject.Find ("right").GetComponent<Renderer> ().material.color = Color.red;
				Gamestart.rightcube = true;
			}
			if (hit == "left") {
				GameObject.Find ("left").GetComponent<Renderer> ().material.color = Color.red;
				Gamestart.leftcube = true;
			}
		} else {
			Debug.Log("null");
		}
	}
}
