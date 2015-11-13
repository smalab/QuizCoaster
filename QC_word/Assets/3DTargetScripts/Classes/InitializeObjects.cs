using UnityEngine;
using System.Collections;

public class InitializeObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Camera_right").GetComponent<CameraControl> ().Initialize (new MoveMe ());
		GameObject.Find ("Target").GetComponent<ScreenRaycast> ().Initialize (new OnScreenCollide ());

	}
	
}


