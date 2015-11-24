﻿using UnityEngine;
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


		//Debug.Log ("ClassName : " + obj2.ClassName);
		Debug.Log (obj["Unity1"]);
		Debug.Log (obj2["Unity1"]);
		Debug.Log ("ObjectId : " + obj2.ObjectId);
		/*Debug.Log ("CreateDate : " + obj2.CreateDate);
		Debug.Log ("UpdateDate : " + obj2.UpdateDate);
		Debug.Log ("ACL : " + obj2.ACL);
		Debug.Log ("IsDirty : " + obj2.IsDirty);
		Debug.Log ("Keys : " + obj2.Keys);*/

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
