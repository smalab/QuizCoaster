using UnityEngine;
using System.Collections;

public class TextCcontroller : MonoBehaviour {

	public GameObject text;
	private Quaternion q;
	private int i;

	// Use this for initialization
	void Start () {
		i = 0;
		Input.gyro.enabled = true;
		text.SendMessage ("Startmessage");
	}
	
	// Update is called once per frame
	void Update () {
		q = Input.gyro.attitude;
		if (q.z >= 0.6f) {
			//text.SendMessage("Message2", i++);
			//text.SendMessage("Message3", i++, i++);
		}
	}

}
