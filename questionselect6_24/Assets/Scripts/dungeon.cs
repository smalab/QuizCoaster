using UnityEngine;
using System.Collections;

public class dungeon : MonoBehaviour {
	private float speed = 0.07f; // dungeonを動かす速さ

	// dungeonをunitychan方向に動かす
	void Update () {
		transform.position += transform.forward * speed;
	}
}
