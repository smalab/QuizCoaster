﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scorecontroller : MonoBehaviour {

	public static int score;
	//public static Text hundred;
	public static int i = 0;
	public GameObject hundred;
	public AudioClip audioclip;
	AudioSource audiosource;

	// Use this for initialization
	void Start () {
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		hundred.GetComponent<Hundredhide>().enabled = true;
		hundred.GetComponent<Hundredappearance>().enabled = false;
		GetComponent<Text> ().text = score.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void Addscore(){
		StartCoroutine("Addition");
	}

	private IEnumerator Addition(){
		hundred.GetComponent<Hundredhide>().enabled = true;
		yield return new WaitForSeconds (1);
		hundred.GetComponent<Hundredappearance>().enabled = true;
		while (i < 50) {
			score += 2;
			i++;
			GetComponent<Text> ().text = score.ToString ();
			audiosource.PlayOneShot (audioclip);
			yield return new WaitForSeconds (0.01f);
		}
		hundred.GetComponent<Hundredappearance>().enabled = false;
		hundred.GetComponent<Hundredhide>().enabled = true;
		i = 0;
	}

	public static void Restscore(){
		score = 0;
	}
}
