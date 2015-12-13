using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.IO;

public class Datepull : MonoBehaviour {

	public string objectid;
	FileStream file;
	Encoding utf8Enc = Encoding.GetEncoding ("UTF-8");
	StreamWriter writer;

	// Use this for initialization

	void Start() {
		NCMBObject obj = new NCMBObject ("Book");
		obj.ObjectId = objectid;
		obj.FetchAsync ((NCMBException e) => {        
			if (e != null) {
				//エラー処理
			} else {    
				//成功時の処理
			}               
		});
		Thread.Sleep (3000);
		Debug.Log (obj.ObjectId);
		Debug.Log (obj["test"]);

		if (File.Exists ("Assets/Resources/log.csv")) {
			Debug.Log ("fileatta");
			file = new System.IO.FileStream ("Assets/Resources/log.csv", FileMode.Append, FileAccess.Write);
			writer = new StreamWriter (file, utf8Enc);
			writer.WriteLine ("");
		}else{
		file = new FileStream("Assets/Resources/log.csv", FileMode.Append, FileAccess.Write);
		writer = new StreamWriter (file, utf8Enc);
		}
		writer.Write(obj["test"]);
		writer.Close();
	}

	// Update is called once per frame
	void Update () {
	
	}
}
