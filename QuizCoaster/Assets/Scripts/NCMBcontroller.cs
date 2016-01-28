using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;
using System.Linq;
using NCMB;

public class NCMBcontroller : MonoBehaviour {

	private string filePath = "/Resources/Logfile/";
	private string fileName = "log.csv";
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
	string[] lines = File.ReadAllLines("Assets/Resources/Logfile/log.csv");

	// Use this for initialization
	void Start () {
		if (File.Exists (Application.dataPath + filePath + fileName))
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
			yesbutton.transform.position = new Vector3(320, 100, 0);
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
		lines = lines.Take(lines.Length - 1).ToArray();
		File.WriteAllLines("Assets/Resources/Logfile/log.csv", lines);
		stageTextAsset = Resources.Load("Logfile/log") as TextAsset;
		stageData = stageTextAsset.text;
		obj.Add ("test", stageData);
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
