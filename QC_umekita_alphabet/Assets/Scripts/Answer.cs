using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Answer : MonoBehaviour {
	public static bool flag1;  //正解と不正解のimageのどちらを押したか
	public static bool flag2;  //imageをタッチしたかどうか
	public Button button;

	void Start() {
		flag1 = false;
		flag2 = false;
	}

	//　タッチした方のtagを代入する
	public void touchimage () {
		if (button.tag == "right") flag1 = true;
		if (button.tag == "mistake") flag1 = false;
		flag2 = true;
	}

	// 正解か不正解のどちらをタッチしたかを返す
	public static bool whichimage(){
		return flag1;
	}

	// imageをタッチしたかどうかを返す
	public static bool touch(){
		return flag2;
	}	
}
