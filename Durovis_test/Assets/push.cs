using UnityEngine;
using System.Collections;
using System.IO;

public class push : MonoBehaviour {

	string folder_name = "Assets/log.csv";
	string str;
	//string pass = Application.persistentDataPath;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void exist(){
		TextAsset log = Resources.Load ("log", typeof(TextAsset)) as TextAsset;
		str = log.text;
		Debug.Log (str);
		File.WriteAllText(Application.persistentDataPath + "/log.csv", log.text);
	}
}