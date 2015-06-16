using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Answer : MonoBehaviour {
	public static bool flag1;  //正解と不正解のimageのどちらを押したか
	public Button button;

	/*void Start() {
		flag1 = false;
	}

	//　タッチした方のtagを代入する
	public void touchimage () {
		if (button.tag == "right") flag1 = true;
		if (button.tag == "mistake") flag1 = false;
	}

	// 正解か不正解のどちらをタッチしたかを返す
	public static bool whichimage(){
		return flag1;
	}*/
}
