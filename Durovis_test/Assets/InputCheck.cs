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
	private float time;
	private float scale = 1.0f;
	private Vector3 position;
	private Vector3 rotation;
	private Vector3 gyro;
	private Vector3 gravity;
	private string position_x;
	private string position_y;
	private string position_z;
	private string gravity_x;
	// 必要な変数を宣言する
	DateTime dtNow = DateTime.Now;

	// Use this for initialization
	void Start()
	{
		Input.gyro.enabled = true;
		if (File.Exists (Application.persistentDataPath + "/log.csv"/*"Assets/Resources/log.csv"*/)) {
			Debug.Log ("fileatta");
			FileStream f = new System.IO.FileStream (Application.persistentDataPath + "/log.csv"/*"Assets/Resources/log.csv"*/, FileMode.Append, FileAccess.Write);
			Encoding utf8Enc = Encoding.GetEncoding ("UTF-8");
			StreamWriter writer = new StreamWriter (f, utf8Enc);
			writer.WriteLine ("");
			writer.Write(dtNow + ",");
			writer.Close ();
		} else {
			FileStream f = new System.IO.FileStream (Application.persistentDataPath + "/log.csv"/*"Assets/Resources/log.csv"*/, FileMode.Append, FileAccess.Write);
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
				position = new Vector3 (-gyro.y, gyro.x, 0) * scale;
				//rotation = new Vector3(gravity.x, gravity.y, gravity.z) * scale;
				this.transform.position = new Vector3 (this.transform.position.x, this.transform.position.y, this.transform.position.z) + position;
				position_x = Mathf.RoundToInt (this.transform.position.x).ToString ();
				position_y = Mathf.RoundToInt (this.transform.position.y).ToString ();
				position_z = Mathf.RoundToInt (this.transform.position.z).ToString ();
				gravity_x = gravity.x.ToString ();
				logSave (position_x, position_y, gravity_x);
				//time = 0.0f;
			}
		}
	}

	public void logSave(string x, string y, string z){
		
		FileStream f = new FileStream(Application.persistentDataPath + "/log.csv"/*"Assets/Resources/log.csv"*/, FileMode.Append, FileAccess.Write);
		Encoding utf8Enc = Encoding.GetEncoding("UTF-8");
		StreamWriter writer = new StreamWriter(f, utf8Enc);
		writer.Write(x + ",");
		writer.Write(y + ",");
		writer.Write(z + ",");
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