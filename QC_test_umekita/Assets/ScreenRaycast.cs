using UnityEngine;
using System.Collections;

public class ScreenRaycast : MonoBehaviour {
	IOnScreenCollide _OnScreenCollide;

	// Use this for initialization
	void Start () {
		_OnScreenCollide = new OnScreenCollide ();
	}

	// Update is called once per frame
	void Update () {
		string hit=_OnScreenCollide.GetRaycastHitTag(transform);
		if (hit != null) {
			if (hit == "Player") {
				Debug.Log ("Player");
			}
		}
	}
}
