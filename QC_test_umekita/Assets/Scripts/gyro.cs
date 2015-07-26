using UnityEngine;
using System.Collections;

public class gyro : MonoBehaviour {

	//public Camera camera;
	private Quaternion q;
	private Quaternion qq;
	public GameObject m_camera;
	private bool disableGyro=false;

		// Use this for initialization
	void Awake(){
		Application.targetFrameRate = 15;
	}
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.localRotation = Quaternion.identity;
		if (disableGyro==false) GyroSupport ();
		KeyboardSupport ();
	}
	void GyroSupport(){
		q = Input.gyro.attitude;
		qq = Quaternion.AngleAxis (-90.0f, Vector3.left);
		q.x *= -1.0f;
		q.y *= -1.0f;
		m_camera.transform.localRotation = qq * q;
		m_camera.transform.localEulerAngles = new Vector3 (0, m_camera.transform.localEulerAngles.y, 0f);
		//Debug.Log ("attiude " + q);
	}
	void KeyboardSupport (){
		if (Input.GetKey(KeyCode.Space)) {
			disableGyro=!disableGyro;
		}
		if (Input.GetKey(KeyCode.LeftArrow)) {
			m_camera.transform.localEulerAngles = new Vector3(0,m_camera.transform.localEulerAngles.y-5f,0f);
		}
		if (Input.GetKey(KeyCode.RightArrow)) {
			m_camera.transform.localEulerAngles = new Vector3(0,m_camera.transform.localEulerAngles.y+5f,0f);
		}
	}

}
