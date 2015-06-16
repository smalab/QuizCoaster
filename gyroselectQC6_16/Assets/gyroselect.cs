using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gyroselect : MonoBehaviour {
	
	public Image image1;
	public Image image2;
	//private string gyro;
	public static string select;
	private GameObject parent1;
	private GameObject parent2;
	private GameObject child1;
	public static bool flag1;
	public bool flag2;

	// Use this for initialization
	void Start () {
		//Input.gyro.enabled = true;
		select = null;
		image1.enabled = false;
		image2.enabled = false;
		flag1 = false;
		flag2 = false;
		gyrocontroller.Ongyro();
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log ("x軸の加速度: " + Input.acceleration.x);
		//Debug.Log ("y軸の加速度: " + Input.acceleration.y);
		//Debug.Log ("z軸の加速度: " + Input.acceleration.z);

		//if (flag2 == false) {
	
			if (/*Input.acceleration.x > 0 && Input.gyro.rotationRateUnbiased.y*/gyrocontroller.y_gyro() < -5.0f) {
				//image1.enabled = true;
				//image2.enabled = false;
				transform.position += new Vector3 (0.01f, 0, 0);
				//image1.color = new Color (79f / 255f, 227f / 255f, 20f / 255f, 1f);
				Debug.Log (image1.color);

				//image2.color = new Color (255, 255, 255);
				select = "right";
				Debug.Log ("y" + Input.gyro.rotationRateUnbiased.y);
				Debug.Log ("Parent:" + image1.tag);
				flag2 = cursor.ok();
			}
			if (/*Input.acceleration.x > 0 && Input.gyro.rotationRateUnbiased.y*/gyrocontroller.y_gyro () > 5.0f) {
				transform.position += new Vector3 (-0.01f, 0, 0);

				//image1.enabled = false;
				//image2.enabled = true;
				//image2.color = new Color (79f / 255f, 227f / 255f, 20f / 255f, 1f);
				//image1.color = new Color (255, 255, 255);
				select = "left";
				Debug.Log ("y" + Input.gyro.rotationRateUnbiased.y);
				flag2 = cursor.ok ();
			} /*else {
			image1.color = new Color (255, 255, 255);
			image2.color = new Color (255, 255, 255);
		}*/
			if (select != null)
				touchimage ();
		//}
	}

	public static string selecti(){
		return select;
	}

	public void touchimage () {
		if (select == "right") tag = image1.tag;
		if (select == "left") tag = image2.tag;
		if (tag == "right") flag1 = true;
		if (tag == "mistake") flag1 = false;
	}

	public static bool whichimage(){
		return flag1;
	}
	
}
