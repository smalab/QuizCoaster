using UnityEngine;
using System.Collections;
using System.IO;
using System;
using System.Text;

public class InputCheck : MonoBehaviour
{
	
	/// <summary>加速度？傾き？</summary>
	private Vector3 acceleration;
	/// <summary>フォント</summary>
	//private GUIStyle labelStyle;
	public Camera camera;
	private float time;
	private float scale = 1.0f;
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
	// 必要な変数を宣言する
	DateTime dtNow = DateTime.Now;

	// Use this for initialization
	void Start()
	{
		Input.gyro.enabled = true;
		if (File.Exists (Application.persistentDataPath + "/log.csv"/*"Assets/Resources/log.csv"*/)) {
			Debug.Log ("fileatta");
			FileStream f = new System.IO.FileStream (Application.dataPath + "/log.csv"/*"Assets/Resources/log.csv"*/, FileMode.Append, FileAccess.Write);
			Encoding utf8Enc = Encoding.GetEncoding ("UTF-8");
			StreamWriter writer = new StreamWriter (f, utf8Enc);
			writer.WriteLine ("");
			writer.Write(dtNow + ",");
			writer.Close ();
		} else {
			FileStream f = new System.IO.FileStream (Application.dataPath + "/log.csv"/*"Assets/Resources/log.csv"*/, FileMode.Append, FileAccess.Write);
			Encoding utf8Enc = Encoding.GetEncoding ("UTF-8");
			StreamWriter writer = new StreamWriter (f, utf8Enc);
			writer.Write(dtNow + ",");
			writer.Close ();
		}

		time = 0.0f;
		Input.gyro.enabled = true;
		//フォント生成
		/*this.labelStyle = new GUIStyle();
		this.labelStyle.fontSize = Screen.height / 22;
		this.labelStyle.normal.textColor = Color.white;*/
	}
	
	// Update is called once per frame
	void Update()
	{
		time += Time.deltaTime;
		if (time > 5.0f) {
			if (Time.frameCount % 15 == 0) {
				gyro = Input.gyro.rotationRateUnbiased;
				gravity = Input.acceleration;
				//this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z) + position;
				rotation_x = Mathf.RoundToInt (camera.transform.rotation.x).ToString ();
				rotation_y = Mathf.RoundToInt (camera.transform.rotation.y).ToString ();
				rotation_z = Mathf.RoundToInt (camera.transform.rotation.z).ToString ();
				gravity_x = gravity.x.ToString ();
				gravity_y = gravity.y.ToString ();
				gravity_z = gravity.z.ToString ();
				gyro_x = gyro.x.ToString();
				gyro_y = gyro.y.ToString();
				gyro_z = gyro.z.ToString();
				logSave (rotation_x, rotation_y, rotation_z, gravity_x, gravity_y, gravity_z, gyro_x, gyro_y, gyro_z);
				//time = 0.0f;
			}
		}
	}

	public void logSave(string rotation_x, string rotation_y, string rotation_z, string gravty_x, string gravty_y, string gravty_z, string gyro_x, string gyro_y, string gyro_z){
		
		FileStream f = new FileStream(Application.dataPath + "/log.csv" /*"Assets/Resources/log.csv"*/, FileMode.Append, FileAccess.Write);
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
		writer.Close();
	}

	/*void OnGUI()
	{
		if (acceleration != null)
		{
			float x = Screen.width / 10;
			float y = 0;
			float w = Screen.width * 8 / 10;
			float h = Screen.height / 20;
			
			for (int i = 0; i < 3; i++)
			{
				y = Screen.height / 10 + h * i;
				string text = string.Empty;
				
				switch (i)
				{
				case 0://X
					text = string.Format("position-X:{0}", System.Math.Round(this.transform.position.x, 3));
					break;
				case 1://Y
					text = string.Format("position-Y:{0}", System.Math.Round(this.transform.position.y, 3));
					break;
				case 2://Z
					text = string.Format("accel-x:{0}", System.Math.Round(gravity.x, 3));
					break;
				default:
					throw new System.InvalidOperationException();
				}
				
				GUI.Label(new Rect(x, y, w, h), text, this.labelStyle);
			}
		}
	}*/
}