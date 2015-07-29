using UnityEngine;
using System.Collections;

public class Addscore : MonoBehaviour {

	public static int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Add(){
		score += 100;
	}

	public void Reset(){
		score = 0;
	}
}
