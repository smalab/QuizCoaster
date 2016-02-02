using UnityEngine;
using System.Collections;

public class CameraInitialize : MonoBehaviour {

	public GameObject camera;
	public GameObject plane;
	float time;

	// Use this for initialization
	void Start () {
		time = 0.0f;
		plane.SetActive(true);

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time < 2.0f) {
			camera.transform.rotation = new Quaternion (0.0f, 0.0f, 0.0f, 0.0f);
		} else {
			plane.SetActive(false);
		}
	}
}
