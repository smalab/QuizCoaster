using UnityEngine;
using System.Collections;
using System;
/*using NCMB;
using System.Collections.Generic;*/

public class Dateadd : MonoBehaviour {

	public Camera camera;
	public string date;
	private string rotate_x;
	private string rotate_y;
	private string rotate_z;
	DateTime dtNow = DateTime.Now;
	

	public float time = 0;
	int number;
	int a = 0;
	bool flag = false;
	string name = "a";
	//NCMBObject obj = new NCMBObject ("Book");

	// Use this for initialization
	void Start () {
		date += dtNow + ",";
	}
	
	// Update is called once per frame
	void Update () {
		time = time + Time.deltaTime;
		if (Time.frameCount % 15 == 0) {
			//Debug.Log(date);
			rotate_x = Omit(camera.transform.rotation.x).ToString ();
			rotate_y = Omit(camera.transform.rotation.y).ToString ();
			rotate_z = Omit(camera.transform.rotation.z).ToString ();
			date += rotate_x + "," + rotate_y + "," + rotate_z + ",";
		}
	}

	public float Omit(float value){
		value *= 100;
		value = Mathf.Floor (value);
		value /= 100;
		return value;
	}

}
