using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cursor : MonoBehaviour {

	public static string whichcursor;
	public GameObject rightcursor;
	public GameObject leftcursor;
	public Image image1;
	public Image image2;
	public float time;
	public static bool flag;
	private bool seflag; //flag of sound effect.
	public AudioClip audioclip;
	AudioSource audiosource;
	Rightchangecolor Rightchangecolor;
	Leftchangecolor Leftchangecolor;

	// Use this for initialization
	void Start () {
		Rightchangecolor = GetComponent<Rightchangecolor> ();
		Leftchangecolor = GetComponent<Leftchangecolor> ();
		seflag = false;
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		time = 3.0f;
		flag = false;
		Rightchangecolor.Disabled ();//image1.enabled = false;
		Leftchangecolor.Disabled ();//image2.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (time);
		if (time < 0.0f && seflag == true) {
			flag = false;
			whichcursor = null;
			audiosource.Play ();
			seflag = false;
		}

		if (time >= 0.0f) {
			if (whichcursor == "rightplane" || whichcursor == "leftplane"){
				time -= Time.deltaTime;
			}else{
				Rightchangecolor.Disabled (); //image1.enabled = false;
				Leftchangecolor.Disabled(); //image2.enabled = false;
				time = 3.0f;
			}

			if (whichcursor == "rightplane") {
				Rightchangecolor.Enabled (); //image1.enabled = true;
				Leftchangecolor.Disabled(); //image2.enabled = false;
				transform.position += new Vector3 (0.01f, 0, 0);
				if(time <= 3.0f && time > 2.0f)	Rightchangecolor.Changegreen();//image1.color = green;
				if(time <= 2.0f && time > 1.0f)	Rightchangecolor.Changeyellow();//image1.color = yellow;
				if(time <= 1.0f && time > 0.0f){
					Rightchangecolor.Changered();//image1.color = red;
					seflag = true;
				}
			}
			if (whichcursor == "leftplane") {
				transform.position += new Vector3 (-0.01f, 0, 0);
				Rightchangecolor.Disabled (); //image1.enabled = false;
				Leftchangecolor.Enabled(); //image2.enabled = true;
				if(time <= 3.0f && time > 2.0f)	Leftchangecolor.Changegreen();//image2.color = green;
				if(time <= 2.0f && time > 1.0f)	Leftchangecolor.Changeyellow();//image2.color = yellow;
				if(time <= 1.0f && time > 0.0f){
					Leftchangecolor.Changered(); //image2.color = red;
					seflag = true;
				}
			}
		} else {
			Rightchangecolor.Disabled (); //image1.enabled = false;
			Leftchangecolor.Disabled(); //image2.enabled = false;
			flag = true;
		}
	}

	public static bool ok(){
		return flag;
	}

}
