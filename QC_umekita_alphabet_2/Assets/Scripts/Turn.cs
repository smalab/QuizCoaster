using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {
	public float time; //カメラを回転させる時間
	bool flag = false; //画面をタッチしたかの判定

	// 画面をタッチしたかどうか
	void Update () {
		if (Touchscreen.touch () == true)
		StartCoroutine ("cameraroll");
	}

	// 画面をタッチしたらカメラを回転させる
	IEnumerator cameraroll(){
		if (flag == false) {
			this.transform.Rotate (new Vector3 (0, 58, 0) * Time.deltaTime);
			yield return new WaitForSeconds(time);
			flag = true;
		}
	}
}