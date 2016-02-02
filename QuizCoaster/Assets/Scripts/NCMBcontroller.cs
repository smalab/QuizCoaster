using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System.Linq;
using NCMB;
using System.Text;
using System;

public class NCMBcontroller : MonoBehaviour {

	string textData;
	private string filePath = "Logfile/log";
	private string fileName = "/log.csv";
	private static bool logfile = false;
	public Text text;
	public Text yestext;
	public Image yesimage;
	public Text notext;
	public Image noimage;
	public Button yesbutton;
	NCMBObject obj = new NCMBObject ("Book");
	public static string objectid;
	public TextAsset stageTextAsset;
	public string stageData;
	string[] lines;// = File.ReadAllLines("Assets/Resources/Logfile/log.csv");

	// Use this for initialization
	void Start () {
		//stageTextAsset = Resources.Load(filePath) as TextAsset;
		//if(stageTextAsset != null)
		if (File.Exists (Application.persistentDataPath + fileName))
			logfile = true;
		//stageTextAsset = Resources.Load(filePath) as TextAsset;
		// 文字列を代入
		//stageData = stageTextAsset.text;
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void LogfileSearch(){
		if(logfile == true){
			text.text = "log.csvがありましたので送信します";
			notext.enabled = false;
			noimage.enabled = false;
			yesbutton.transform.position = new Vector3(yesbutton.transform.position.x + 3.3f, yesbutton.transform.position.y, yesbutton.transform.position.z);
		}else{
			text.text = "log.csvがありませんでしたのでアプリを終了してください";
			yestext.enabled = false;
			yesimage.enabled = false;
			notext.enabled = false;
			noimage.enabled = false;
		}
		Debug.Log ("logsearch");
	}

	public void Datapush(){
		yestext.enabled = false;
		yesimage.enabled = false;
		text.text = "少々お待ちください";
		/*lines = lines.Take(lines.Length - 1).ToArray();
		File.WriteAllLines("Assets/Resources/Logfile/log.csv", lines);*/
		FileInfo fi = new FileInfo(Application.persistentDataPath + fileName);
		StreamReader reader = new StreamReader(
			// Application.dataPathで/Assets/filePathになる
			Application.persistentDataPath+fileName,
			// エンコーディング
			System.Text.Encoding.GetEncoding("utf-8"));
		// 内容をすべて読み込む
		textData = reader.ReadToEnd();
		reader.Close();

		//string filetext = File.ReadAllText(Application.persistentDataPath + filePath);
		//stageTextAsset = Resources.Load(filePath) as TextAsset;
		//stageData = stageTextAsset.text;
		obj.Add ("test", textData);
		obj.SaveAsync ((NCMBException e) => {      
			if (e != null) {
				text.text = "送信できませんでした.ネット環境と正しく繋がっているか確認してください.\nアプリを終了してください";
				Debug.Log ("erro:::::");//エラー処理
			} else {
				text.text = "log.csvを送信しました.ObjectIDは" + obj.ObjectId + "です.\nアプリを終了してください";
				//成功時の処理
			}                   
		});
	}
}
