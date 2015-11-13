using UnityEngine;
using System.Collections;

public class Gamestart : MonoBehaviour {

	public static bool rightcube;
	public static bool leftcube;

	// Use this for initialization
	void Start () {
		rightcube = false;
		leftcube = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(rightcube == true && leftcube == true) QuestionSelect.StartUp();
	}
}
