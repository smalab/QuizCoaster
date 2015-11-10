using UnityEngine;
using System.Collections;

public class ScreenRaycast : MonoBehaviour {
	IOnScreenCollide _OnScreenCollide;
	Gamestart Gamestart;
	cursor cursor;

	void Start(){
		Gamestart = gameObject.GetComponent<Gamestart> ();
		cursor = gameObject.GetComponent<cursor> ();

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
		Debug.Log (hit);

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
