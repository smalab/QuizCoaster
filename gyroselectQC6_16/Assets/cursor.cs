using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cursor : MonoBehaviour {

	private string gyro;
	public Image image1;
	public Image image2;
	public float time;
	public static bool flag;

	// Use this for initialization
	void Start () {
		time = 3.0f;
		flag = false;
		Input.gyro.enabled = true;
		image1.enabled = false;
		image2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (time >= 0.0f) {
			if (gyroselect.selecti () != null)
				time -= Time.deltaTime;
			Debug.Log ("time " + time);
			if (/*Input.gyro.rotationRateUnbiased.y*/gyrocontroller.y_gyro() < -5.0f)
				time = 3.0f;
			if (/*Input.gyro.rotationRateUnbiased.y*/ gyrocontroller.y_gyro() > 5.0f)
				time = 3.0f;

			if (gyroselect.selecti () == "right") {
				image1.enabled = true;
				image2.enabled = false;
				transform.position += new Vector3 (0.01f, 0, 0);
				image1.color = new Color (79f / 255f, 227f / 255f, 20f / 255f, 1f);
				//StartCoroutine("count");
			}
			if (gyroselect.selecti () == "left") {
				transform.position += new Vector3 (-0.01f, 0, 0);
				image1.enabled = false;
				image2.enabled = true;
				image2.color = new Color (79f / 255f, 227f / 255f, 20f / 255f, 1f);
			}
		} else {
			flag = true;
			gyrocontroller.Offgyro();
		}
		Debug.Log ("flagggggggg" + flag);

	}

	private IEnumerator count(){
		yield return new WaitForSeconds(3);
		flag = true;
	}

	public static bool ok(){
		return flag;
	}

}
