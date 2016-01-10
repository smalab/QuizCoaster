using UnityEngine;
using System.Collections;

public class DifficultyMove : MonoBehaviour {

	ScreenRaycast ScreenRaycast;
	DifficultyCursor DifficultyCusor;
	private Animator anim;
	private Collider col;
	private float speed = 0.12f; //unitychanが走る速さ
	public static Transform target; // タッチしたimageの位置を代入するための変数
	
	
	void Start () {
		ScreenRaycast = GetComponent<ScreenRaycast> ();
		DifficultyCusor = GetComponent<DifficultyCursor> ();
		anim = GetComponent<Animator> ();
	}
	
	//　unitychanをタッチしたimageの方向に動かす
	void Update () {
		//Debug.Log (target);
		if (DifficultyCursor.ok () == true) {  // imageをタッチしたかどうかの判定
			// unitychanをタッチしたimageの方向に向けて動かす

			target = GameObject.Find("leftplane").GetComponent<Transform>();
			anim.SetTrigger ("run");
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), speed);
			transform.position += transform.forward * speed;
		} /*else {
			Debug.Log ("easy");
			if (ScreenRaycast.hittag == "easy") { // 正解と不正解のどちらにタッチしたか
				target = ScreenRaycast.hittransform;//new Vector3(left.position.x, left.position.y, left.position.z);//正解のimageの位置を代入
			} else if(ScreenRaycast.hittag == "hard"){
				Debug.Log ("hard");
				target = ScreenRaycast.hittransform; //不正解のimageの位置を代入
			}
		}*/
	}
	void OnTriggerEnter() {
		Application.LoadLevel ("Question");
	}
}
