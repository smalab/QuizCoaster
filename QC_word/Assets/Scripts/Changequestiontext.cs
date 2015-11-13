using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Changequestiontext : MonoBehaviour {
	
	//	public GameObject problem;
	
	// Use this for initialization
	void Start () {
		GameObject.Find ("problem").GetComponent<Text>().text = "Please select ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public static void Change(string name){
		GameObject problem = GameObject.Find ("problem");
		string temp = problem.GetComponent<Text>().text;
		temp = temp + name;
		problem.GetComponent<Text> ().text = temp;
		
	}
}
