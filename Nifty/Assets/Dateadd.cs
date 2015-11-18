using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;

public class Dateadd : MonoBehaviour {

	float time = 0;
	int number;
	int a = 0;
	bool flag = false;
	string name = "a";
	NCMBObject obj = new NCMBObject ("Book");

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("time : " + time);
		Debug.Log ("count : " + a);
		time = time + Time.deltaTime;
		name += ",a,a,a,a,a,a,a,a";
		/*if ((int)time % 2 == 1 && flag == true) {
			obj.Add ("test", name);
			obj.SaveAsync ((NCMBException e) => {      
				if (e != null) {
					Debug.Log ("erro:::::");//エラー処理
				} else {
					Debug.Log ("go:::::::");
					//成功時の処理
				}                   
			});
			a++;
			flag = false;
			time = 0.0f;
		} else {
			flag = true;
		}*/
		if (time > 60.0f) {
			name += "bbbbb";
			obj.Add ("test", name);
			obj.SaveAsync ((NCMBException e) => {      
				if (e != null) {
					Debug.Log ("erro:::::");//エラー処理
				} else {
					Debug.Log ("go:::::::");
					//成功時の処理
				}                   
			});
		}
	}
}
