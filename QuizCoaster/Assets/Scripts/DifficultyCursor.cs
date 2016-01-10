using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DifficultyCursor : MonoBehaviour {
	
	public static bool changeflag;
	bool waitflag;
	public GameObject rightcursor;
	public GameObject leftcursor;
	public Image image1;
	public Image image2;
	public float time;
	public static bool flag;
	private bool seflag; //flag of sound effect.
	public AudioClip audioclip;
	static string rankword = "";
	public static string difficulty; //easyかhardのどちらかを格納する
	AudioSource audiosource;
	Rightchangecolor Rightchangecolor;
	Leftchangecolor Leftchangecolor;
	ScreenRaycast ScreenRaycast;
	BalloonScaling BallonScaling;
	
	// Use this for initialization
	void Start () {
		rankword = "difficulty";
		ScreenRaycast = GetComponent<ScreenRaycast> ();
		Rightchangecolor = GetComponent<Rightchangecolor> ();
		Leftchangecolor = GetComponent<Leftchangecolor> ();
		BallonScaling = GetComponent<BalloonScaling> ();
		seflag = false;
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		time = 3.0f;
		changeflag = false;
		waitflag = false;
		flag = false;
		Rightchangecolor.Disabled ();//image1.enabled = false;
		Leftchangecolor.Disabled ();//image2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
if (waitflag == false) {
			if (time < 0.0f && seflag == true) {
				flag = false;
				waitflag = true;
				//whichcursor = null;
				Rightchangecolor.Disabled (); //image1.enabled = false;
				Leftchangecolor.Disabled (); //image2.enabled = false;
				audiosource.Play ();
				BalloonScaling.Scaling();
				if (ScreenRaycast.hittag == "yes"){
					rankword = "go";
					Debug.Log("difficulty : " + difficulty);
					flag = true;
				}
				StartCoroutine ("Wait");
				seflag = false;
			}
		
			if (time >= 0.0f) {
				if (ScreenRaycast.hitname == "rightplane" || ScreenRaycast.hitname == "leftplane") {
					time -= Time.deltaTime;
				} else {
					Rightchangecolor.Disabled (); //image1.enabled = false;
					Leftchangecolor.Disabled (); //image2.enabled = false;
					time = 3.0f;
				}
			
				if (ScreenRaycast.hitname == "rightplane") {
					Rightchangecolor.Enabled (); //image1.enabled = true;
					Leftchangecolor.Disabled (); //image2.enabled = false;
					transform.position += new Vector3 (0.01f, 0, 0);
					if (time <= 3.0f && time > 2.0f)
						Rightchangecolor.Changegreen ();//image1.color = green;
					if (time <= 2.0f && time > 1.0f)
						Rightchangecolor.Changeyellow ();//image1.color = yellow;
					if (time <= 1.0f && time > 0.0f) {
						Rightchangecolor.Changered ();//image1.color = red;
						seflag = true;
					}
				}
				if (ScreenRaycast.hitname == "leftplane") {
					transform.position += new Vector3 (-0.01f, 0, 0);
					Rightchangecolor.Disabled (); //image1.enabled = false;
					Leftchangecolor.Enabled (); //image2.enabled = true;
					if (time <= 3.0f && time > 2.0f)
						Leftchangecolor.Changegreen ();//image2.color = green;
					if (time <= 2.0f && time > 1.0f)
						Leftchangecolor.Changeyellow ();//image2.color = yellow;
					if (time <= 1.0f && time > 0.0f) {
						Leftchangecolor.Changered (); //image2.color = red;
						seflag = true;
					}
				}
				changeflag = false;
			} else {
				changeflag = true;
				if (ScreenRaycast.hittag == "no")
					rankword = "difficulty";
				if (ScreenRaycast.hittag == "easy" || ScreenRaycast.hittag == "hard"){
					difficulty = ScreenRaycast.hittag;
					rankword = "answer";
				}
			}
		}
	}
	
	public static bool ok(){
		return flag;
	}

	public static string rank(){
		return rankword;
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (2);
		waitflag = false;
		time = 3.0f;
	}
}
