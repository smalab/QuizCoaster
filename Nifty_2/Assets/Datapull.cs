using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using NCMB;
using System.Collections.Generic;
using System.Threading;
using System.Text;
using System.IO;

public class Datapull : MonoBehaviour {

	public Text objectidtext;
	public Image inputimage;
	public Text inputtext;
	public Image buttonimage;
	public Text buttontext;
	public bool pull;
	public Text objectid;
	public Text text;
	//public string objectid;
	FileStream file;
	Encoding utf8Enc = Encoding.GetEncoding ("UTF-8");
	StreamWriter writer;
	public static NCMBObject obj = new NCMBObject ("Book");

	// Use this for initialization

	void Start() {
		pull = false;
	}

	// Update is called once per frame
	void Update () {
		if (pull) {
			obj.ObjectId = objectid.text;
			obj.FetchAsync ((NCMBException e) => {        
				if (e != null) {
					text.text = "該当するObjectIDが見つかりませんでした.\nもう一度ObjectIDを確認してください.";
					//エラー処理
				} else {
					text.text = "ObjectIDが見つかりました.\nRreourcesにlog.csvとして保存しました.";
					//成功時の処理
				}               
			});
			Thread.Sleep (3000);
			objectidtext.enabled = false;
			inputimage.enabled = false;
			inputtext.enabled = false;
			buttonimage.enabled = false;
			buttontext.enabled = false;
			//Debug.Log (obj.ObjectId);
			//Debug.Log (obj["test"]);
		
			if (File.Exists ("Assets/Resources/log.csv")) {
				Debug.Log ("fileatta");
				file = new System.IO.FileStream ("Assets/Resources/log.csv", FileMode.Append, FileAccess.Write);
				writer = new StreamWriter (file, utf8Enc);
				writer.WriteLine ("");
			} else {
				file = new FileStream ("Assets/Resources/log.csv", FileMode.Append, FileAccess.Write);
				writer = new StreamWriter (file, utf8Enc);
			}
			writer.Write (obj ["test"]);
			writer.Close ();
			pull = false;
		}
	}
}