using UnityEngine;
using System.Collections;

public class Touchscreen : MonoBehaviour {
	public static bool flag = false; //タッチしたかどうかの判定

	void Start () {
		flag = false;
	}

	// 画面をタッチしたら呼び出す
	public void Startgame () {
		flag = true;
	}

	// タッチしたかどうかを返す
	public static bool touch(){
		return flag;
	}
}
