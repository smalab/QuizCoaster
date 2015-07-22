using UnityEngine;
using System.Collections;

public class Hitbucket : MonoBehaviour {

	public GameObject unity;
	public float speed = 0.07f;

	// Use this for initialization
	void Start () {
		unity = GameObject.Find("unitychan");
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (unity.transform.position - transform.position), speed);
		transform.position += transform.forward * speed;
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "unitychan") {
			Debug.Log ("entertag");
			gameObject.GetComponent<Hitbucket> ().enabled = false;
		}
	}
}
