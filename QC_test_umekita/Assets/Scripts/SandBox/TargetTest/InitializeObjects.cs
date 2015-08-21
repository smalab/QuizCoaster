using UnityEngine;
using System.Collections;

public class InitializeObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject.Find ("Main Camera").GetComponent<CameraControl> ().Initialize (new MoveMe ());
	}
	
}
