using UnityEngine;
using System.Collections;

public class CameraInitialize : MonoBehaviour {
	
	public GameObject obj;
	private float time = 0;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0.0f;
		Time.timeScale = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (time);
		time += Time.deltaTime;
		if(time > 3.0f){
			//Time.timeScale = 0.0f;
	}else{
			//obj.transform.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);

		}
	}
}
