using UnityEngine;
using System.Collections;

public class dungeon : MonoBehaviour {
	public float speed; // dungeonを動かす速さ

	// dungeonをunitychan方向に動かす
	void Update () {
		transform.position += transform.forward * speed;
	}
}
