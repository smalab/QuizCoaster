using UnityEngine;
using System.Collections;

public class ScreenRaycast : MonoBehaviour {
	IOnScreenCollide _OnScreenCollide;
	Gamestart Gamestart;
	cursor cursor;
	public static string hitname;
	public static string hittag;
	public static Transform hittransform;

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
		hitname = _OnScreenCollide.GetRaycastHitName(transform);
		hittag = _OnScreenCollide.GetRaycastHitTag(transform);
		hittransform = _OnScreenCollide.GetRaycastHitTransform(transform);
		cursor.whichcursor = hitname;

		if (hitname != null) {
			if (hitname == "easy") {
				Debug.Log ("easy");
				GameObject.Find ("easy").GetComponent<Renderer> ().material.color = Color.red;
				Gamestart.rightcube = true;
			}
			if (hitname == "hard") {
				Debug.Log ("hard");
				GameObject.Find ("hard").GetComponent<Renderer> ().material.color = Color.red;
				Gamestart.leftcube = true;
			}
		} else {
			Debug.Log("null");
		}
	}
}
