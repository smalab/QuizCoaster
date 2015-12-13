using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;

public class push : MonoBehaviour {

	NCMBObject obj = new NCMBObject ("Book");
	public GameObject a;
	public static Dateadd dateadd;
	// Use this for initialization
	void Start () {
		dateadd = a.GetComponent<Dateadd> ();
		Debug.Log (dateadd.time);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void datepush(){
		Debug.Log (dateadd.time);
		obj.Add ("test", dateadd.date);
		Debug.Log ("start");
		obj.SaveAsync ((NCMBException e) => {      
			if (e != null) {
				Debug.Log ("erro:::::");//エラー処理
			} else {
				Debug.Log ("go:::::::");
				//成功時の処理
			}                   
		});
		Debug.Log ("OK");
	}
}
