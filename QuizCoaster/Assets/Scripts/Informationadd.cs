﻿using UnityEngine;
using System.Collections;
using System;
using System.IO;
using System.Text;

public class Informationadd : MonoBehaviour {

	float time;
	private string presentscene; //現在のシーン
	private string beforescene; //前のシーン
	public bool DontDestroyEnabled = true;
	private string filePath = "/Resources/Logfile/";
	private string fileName = "/log.csv";
	public GameObject camera;
	private Vector3 rotation;
	private Vector3 gyro;
	private Vector3 gravity;
	private string rotation_x;
	private string rotation_y;
	private string rotation_z;
	private string gyro_x;
	private string gyro_y;
	private string gyro_z;
	private string gravity_x;
	private string gravity_y;
	private string gravity_z;
	DateTime dtNow = DateTime.Now;
	public TextAsset stageTextAsset;
	public string stageData;
	
	// Use this for initialization
	void Start () {
		time = 0.0f;
		stageTextAsset = Resources.Load ("Logfile/log") as TextAsset;
		//stageData = stageTextAsset.text;
		Debug.Log ("filekakunin " + stageTextAsset);
		Input.gyro.enabled = true;
		presentscene = Application.loadedLevelName;
		beforescene = Application.loadedLevelName;
		if (DontDestroyEnabled)
			DontDestroyOnLoad (this); // Sceneを遷移してもオブジェクトが消えないようにする
		camera = GameObject.Find ("Camera_right");
		//Resources/Logfileにlog.csvがあるか検索しあれば次の行から書き込む
		//if (File.Exists (Application.dataPath + filePath + fileName)) {
		if(stageTextAsset != null){
			Debug.Log ("fileatta");
			StreamWriter sw = new StreamWriter(Application.persistentDataPath + fileName, true);
			sw.WriteLine ("");
			sw.Write (dtNow + ",");
			sw.Flush();
			sw.Close();
			/*FileStream f = new System.IO.FileStream (Application.dataPath + filePath + fileName, FileMode.Append, FileAccess.Write);
			Encoding utf8Enc = Encoding.GetEncoding ("UTF-8");
			StreamWriter writer = new StreamWriter (f, utf8Enc);
			writer.WriteLine ("");
			writer.Write (dtNow + ",");
			writer.Close ();*/
		} else {
			Debug.Log ("filenai");
			StreamWriter sw = new StreamWriter(Application.persistentDataPath + fileName, true);
			sw.Write (dtNow + ",");
			sw.Flush();
			sw.Close();
			//Resources/Logfileにlog.csvが無ければlog.csvを作成し書き込む
			/*FileStream f = new System.IO.FileStream (Application.dataPath + filePath + fileName, FileMode.Append, FileAccess.Write);
			Debug.Log ("kakikomi1");
			Encoding utf8Enc = Encoding.GetEncoding ("UTF-8");
			Debug.Log ("kakikomi2");
			StreamWriter writer = new StreamWriter (f, utf8Enc);
			Debug.Log ("kakikomi3");
			writer.Write (dtNow + ",");
			Debug.Log ("kakikomi4");
			writer.Close ();
			Debug.Log ("kakikomi5");*/
		}
	}
	
	// Update is called once per frame
	void Update () {
		time += Time.deltaTime;
		//Debug.Log ("filekakunin " + Resources.Load("Logfile/log"));
		//シーンが遷移した時にCamera_rightというオブジェクトを検索しcameraにアタッチする
		presentscene = Application.loadedLevelName;
		if (presentscene != beforescene) {
			camera = GameObject.Find ("Camera_right");
			beforescene = Application.loadedLevelName;
		}
		gyro = Input.gyro.rotationRateUnbiased;
		gravity = Input.acceleration;
		if (time > 0.1f/*Time.frameCount % 15 == 0*/) {
			rotation_x = Omit(camera.transform.rotation.x).ToString ();
			rotation_y = Omit(camera.transform.rotation.y).ToString ();
			rotation_z = Omit(camera.transform.rotation.z).ToString ();
			gravity_x = gravity.x.ToString ();
			gravity_y = gravity.y.ToString ();
			gravity_z = gravity.z.ToString ();
			gyro_x = gyro.x.ToString();
			gyro_y = gyro.y.ToString();
			gyro_z = gyro.z.ToString();
			logSave (rotation_x, rotation_y, rotation_z, gravity_x, gravity_y, gravity_z, gyro_x, gyro_y, gyro_z);
			time = 0.1f;
		}
	}
	//小数点3位以下を切り捨て
	public float Omit(float value){
		value *= 100;
		value = Mathf.Floor (value);
		value /= 100;
		return value;
	}
	public void logSave(string rotation_x, string rotation_y, string rotation_z, string gravty_x, string gravty_y, string gravty_z, string gyro_x, string gyro_y, string gyro_z){
		/*FileStream f = new FileStream(Application.dataPath + filePath + fileName, FileMode.Append, FileAccess.Write);
		Encoding utf8Enc = Encoding.GetEncoding("UTF-8");
		StreamWriter writer = new StreamWriter(f, utf8Enc);
		writer.Write(rotation_x + ",");
		writer.Write(rotation_y + ",");
		writer.Write(rotation_z + ",");
		writer.Write(gravty_x + ",");
		writer.Write(gravty_y + ",");
		writer.Write(gravty_z + ",");
		writer.Write(gyro_x + ",");
		writer.Write(gyro_y + ",");
		writer.Write(gyro_z + ",");
		writer.Close();*/
		StreamWriter sw = new StreamWriter(Application.persistentDataPath + fileName, true);
		sw.Write(rotation_x + ",");
		sw.Write(rotation_y + ",");
		sw.Write(rotation_z + ",");
		sw.Write(gravty_x + ",");
		sw.Write(gravty_y + ",");
		sw.Write(gravty_z + ",");
		sw.Write(gyro_x + ",");
		sw.Write(gyro_y + ",");
		sw.Write(gyro_z + ",");
		sw.Flush();
		sw.Close();
	}
}
