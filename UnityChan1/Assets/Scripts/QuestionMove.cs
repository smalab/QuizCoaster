using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestionMove : MonoBehaviour {
	public Transform right;
	public Transform mistake;
	public Button rightbutton;
	public Button mistakebutton;
	public Image rightimage;
	public Image mistakeimage;
	private Collider col;
	private float speed = 0.07f; //unitychanが走る速さ
	private Transform target; // タッチしたimageの位置を代入するための変数

	void Start () {
		target = null;
		rightbutton.enabled = true;
		mistakebutton.enabled = true;
		rightimage.enabled = true;
		mistakeimage.enabled = true;
	}
	
	//　unitychanをタッチしたimageの方向に動かす
	void Update () {
		if (Answer.touch () == true) {  // imageをタッチしたかどうかの判定
			rightbutton.enabled = false;
			mistakebutton.enabled = false;
			rightimage.enabled = false;
			mistakeimage.enabled = false;
			if (Answer.whichimage () == true) { // 正解と不正解のどちらにタッチしたか
				target = right; //正解のimageの位置を代入
			} else {
				target = mistake; //不正解のimageの位置を代入
			}

			// unitychanをタッチしたimageの方向に向けて動かす
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), speed);
			transform.position += transform.forward * speed;
		}
	}
}
