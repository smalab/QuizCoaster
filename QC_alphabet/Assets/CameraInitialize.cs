using UnityEngine;
using System.Collections;

public class CameraInitialize : MonoBehaviour {

	public Camera camera;

	// Use this for initialization
	void Start () {
		camera.transform.rotation = new Quaternion (0.0f, 0.0f, 0.0f, 0.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
