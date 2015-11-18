using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;
using System.Threading;

public class Datepull : MonoBehaviour {

	// Use this for initialization
	void Start () {
		NCMBObject obj = new NCMBObject ("Book");
		obj.Add ("Unity1", "fetchTest");
		obj.SaveAsync ();
		Thread.Sleep (3000);//非同期待ち
		
		//保存したオブジェクトのobjectIdをもとに取得を行う
		NCMBObject obj2 = new NCMBObject ("Book");
		obj2.ObjectId = obj.ObjectId;
		obj2.FetchAsync ((NCMBException e) => {        
			if (e != null) {
				//エラー処理
			} else {    
				//成功時の処理
			}               
		});
		Debug.Log ("a");
		obj2.Increment ("test");

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
