using UnityEngine;
using System.Collections;

public class dungeon : MonoBehaviour {
	private float speed = 0.1f; // dungeonを動かす速さ

	// dungeonをunitychan方向に動かす
	void Update () {
		Debug.Log ("daungeon");
		transform.position += transform.forward * speed;
	}
}
