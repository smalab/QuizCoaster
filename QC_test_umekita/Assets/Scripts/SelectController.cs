using UnityEngine;
using System.Collections;

public class SelectController : MonoBehaviour {
	
	private Animator anim;
	private float speed = 0.07f; // unitychanを走らせる速さ
	private bool flag; // imageのtagを取得したかどうかの判定
	public static string truefalse; //問題が正解か不正解かの判断

	void Start () {
		truefalse = "";
		anim = GetComponent<Animator> ();
		gameObject.GetComponent<QuestionMove> ().enabled = true;
	}
	
	// imageをタッチしたらそのimageの方に走って移動する
	void Update (){
		if (cursor.ok () == true) // imageにタッチしたかどうか
			anim.SetTrigger ("run");
		
		// imageのtagを取得するとその方向に走る
		if (flag == true) {
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (transform.position - new Vector3 (0, 0, 0)), speed);
			transform.position += transform.forward * speed;
		}
	}
	
	// imageにタッチするとそのimageのtagを取得しそのimageのcolliderに当たると次のsceneに遷移する
	void OnTriggerEnter(Collider col) {
		truefalse = col.tag;
		if (TrueMove.countnumber == random.questionnumber - 1) {
			Application.LoadLevel ("trsure_box");
		} else {
			if (col.tag == "right") {
				gameObject.GetComponent<QuestionMove> ().enabled = false;
				Application.LoadLevel ("True");
			}
			if (col.tag == "mistake") {
				//TrueMove.reset ();
				gameObject.GetComponent<QuestionMove> ().enabled = false;
				Application.LoadLevel ("False");
			}
		}
		flag = true;
	}
}