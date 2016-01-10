using UnityEngine;
using System.Collections;

public class dungeon : MonoBehaviour {
	public float speed; // dungeonを動かす速さ
	GameObject bucket;

	// dungeonをunitychan方向に動かす
	void Update () {
		//Debug.Log (False.bucket);
		bucket = GameObject.Find ("bucket_a_pref(Clone)");
		if (bucket != null)
			bucket.transform.position += transform.forward * speed;
		transform.position += transform.forward * speed;
	}
}
