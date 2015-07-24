using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	// 壁を上から下に移動させる
	void Update () {
		if (transform.position.y > 2.5f) {
			transform.position -= new Vector3 (0, 0.03f, 0);
		}
	}
}
