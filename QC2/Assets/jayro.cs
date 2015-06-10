using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class jayro : MonoBehaviour {

	public Image image1;
	public Image image2;
	private string gyro;

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log ("x軸の加速度: " + Input.acceleration.x);
		//Debug.Log ("y軸の加速度: " + Input.acceleration.y);
		//Debug.Log ("z軸の加速度: " + Input.acceleration.z);


		if (/*Input.acceleration.x > 0 && */Input.gyro.rotationRateUnbiased.y < -3.0f) {
			transform.position += new Vector3(0.01f, 0, 0);
			image1.color = new Color (0, 0, 0);
			image2.color = new Color (255, 255, 255);
			Debug.Log("y" + Input.gyro.rotationRateUnbiased.y);
		} /*else*/ if (/*Input.acceleration.x > 0 && */Input.gyro.rotationRateUnbiased.y > 3.0f) {
			transform.position += new Vector3(-0.01f, 0, 0);
			image2.color = new Color (0, 0, 0);
			image1.color = new Color (255, 255, 255);
			Debug.Log ("y" + Input.gyro.rotationRateUnbiased.y);
		} /*else {
			image1.color = new Color (255, 255, 255);
			image2.color = new Color (255, 255, 255);
		}*/
	}

}
