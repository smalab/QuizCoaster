using UnityEngine;
using System.Collections;

public class gyro : MonoBehaviour {

	//public Camera camera;
	private Quaternion q;
	private Quaternion qq;
	public GameObject m_camera;

		// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
		//transform.localRotation = Quaternion.identity;
		q = Input.gyro.attitude;
		qq = Quaternion.AngleAxis(-90.0f, Vector3.left);
		q.x *= -1.0f;
		q.y *= -1.0f;
		m_camera.transform.localRotation = qq * q;
		//Debug.Log ("attiude " + q);

	}
}
