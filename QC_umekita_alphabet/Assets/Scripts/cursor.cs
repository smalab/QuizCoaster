using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cursor : MonoBehaviour {

	private string gyro;
	public Image image1;
	public Image image2;
	public float time;
	public static bool flag;
	private bool seflag;
	private Color green = new Color (79f / 255f, 227f / 255f, 20f / 255f, 1f);
	private Color yellow = new Color (246f / 255f, 1f, 96f / 255, 1f);
	private Color red = new Color (1f, 0f, 0f, 1f);
	public AudioClip audioclip;
	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		seflag = false;
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		time = 3.0f;
		flag = false;
		Input.gyro.enabled = true;
		image1.enabled = false;
		image2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (time < 0.0f && seflag == true) {
			audiosource.Play ();
			seflag = false;
		}

		if (time >= 0.0f) {
			if (gyroselect.selecti () != null)
				time -= Time.deltaTime;
			Debug.Log ("time " + time);
			if (gyrocontroller.y_gyro() < -5.0f)
				time = 3.0f;
			if (gyrocontroller.y_gyro() > 5.0f)
				time = 3.0f;

			if (gyroselect.selecti () == "right") {
				image1.enabled = true;
				image2.enabled = false;
				transform.position += new Vector3 (0.01f, 0, 0);
				if(time <= 3.0f && time > 2.0f)	image1.color = green;
				if(time <= 2.0f && time > 1.0f)	image1.color = yellow;
				if(time <= 1.0f && time > 0.0f){
					image1.color = red;
					seflag = true;
				}
			}
			if (gyroselect.selecti () == "left") {
				transform.position += new Vector3 (-0.01f, 0, 0);
				image1.enabled = false;
				image2.enabled = true;
				if(time <= 3.0f && time > 2.0f)	image2.color = green;
				if(time <= 2.0f && time > 1.0f)	image2.color = yellow;
				if(time <= 1.0f && time > 0.0f){
					image2.color = red;
					seflag = true;
				}
			}
		} else {
			image1.enabled = false;
			image2.enabled = false;
			flag = true;
			gyrocontroller.Offgyro();
		}
	}

	public static bool ok(){
		return flag;
	}

}
