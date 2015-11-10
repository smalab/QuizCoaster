using UnityEngine;
using System.Collections;

public class next : MonoBehaviour {


	private float time;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		if (time > 4.0f)
			Application.LoadLevel ("gyro");
	}
}
