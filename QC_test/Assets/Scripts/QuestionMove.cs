using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class QuestionMove : MonoBehaviour {
	/*public Transform right;
	public Transform mistake;
	public Button rightbutton;
	public Button mistakebutton;
	public Image rightimage;
	public Image mistakeimage;*/
	private Collider col;
	private float speed = 0.07f; //unitychanが走る速さ
	public static Transform target; // タッチしたimageの位置を代入するための変数
	//TextureManager TextureManager;

	void Start () {
		//target = null;
		//TextureManager = GetComponent<TextureManager> ();
		//left = TextureManager.leftPosition;
		/*rightbutton.enabled = true;
		mistakebutton.enabled = true;
		rightimage.enabled = true;
		mistakeimage.enabled = true;*/
	}
	
	//　unitychanをタッチしたimageの方向に動かす
	void Update () {
		//Debug.Log ("transform " + target.position);
		if (cursor.ok () == true) {  // imageをタッチしたかどうかの判定
			Debug.Log ("QuetionMove");
			//rightbutton.enabled = false;
			//mistakebutton.enabled = false;
			//rightimage.enabled = false;
			//mistakeimage.enabled = false;
			if (gyroselect.selecti ()!= "left") { // 正解と不正解のどちらにタッチしたか

				target = TextureManager.leftPosition;//new Vector3(left.position.x, left.position.y, left.position.z);//正解のimageの位置を代入

			} else {
				target = TextureManager.rightPosition; //不正解のimageの位置を代入
			}

			// unitychanをタッチしたimageの方向に向けて動かす
			transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (target.position - transform.position), speed);
			transform.position += transform.forward * speed;
		}
	}
}
