using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestionMove : MonoBehaviour {

	cursor cursor;
	private Collider col;
	private float speed = 0.07f; //unitychanが走る速さ
	public static Transform target; // タッチしたimageの位置を代入するための変数

	
	void Start () {
		cursor = gameObject.GetComponent<cursor> ();
	}
	
	//　unitychanをタッチしたimageの方向に動かす
	void Update () {
		Debug.Log (target);
		if (cursor.ok () == true) {  // imageをタッチしたかどうかの判定
			// unitychanをタッチしたimageの方向に向けて動かす
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), speed);
			transform.position += transform.forward * speed;
		} else {
			if (cursor.whichcursor == "leftplane") { // 正解と不正解のどちらにタッチしたか
				target = TextureManager.leftPosition;//new Vector3(left.position.x, left.position.y, left.position.z);//正解のimageの位置を代入
			} else {
				target = TextureManager.rightPosition; //不正解のimageの位置を代入
			}
		}
	}
}
