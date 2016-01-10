using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Changequestiontext : MonoBehaviour {
	
	//	public GameObject problem;
	
	// Use this for initialization
	public static Dictionary<string, string> alphabet = new Dictionary<string, string>()
	{
		{ "A", "エイ" },
		{ "B", "ビー" },
		{ "C", "シー" },
		{ "D", "ディー" },
		{ "E", "イー" },
		{ "F", "エフ" },
		{ "G", "ジー" },
		{ "H", "エイチ" },
		{ "I", "アイ" },
		{ "J", "ジェイ" },
		{ "K", "ケイ" },
		{ "L", "エル" },
		{ "M", "エム" },
	};

	public static string value;
	public static bool alphabetget;
	//public GameObject problem;

	void Start () {
		GameObject.Find ("problem").GetComponent<TextMesh>().text = "Please select ";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public static void Change(string name){
		if (DifficultyCursor.difficulty == "easy") {
			alphabetget = alphabet.TryGetValue (name, out value);
			GameObject problem = GameObject.Find ("problem");
			string temp = problem.GetComponent<TextMesh> ().text;
			temp = temp + value;
			problem.GetComponent<TextMesh> ().text = temp;
		} else if (DifficultyCursor.difficulty == "hard") {
			GameObject problem = GameObject.Find ("problem");
			string temp = problem.GetComponent<TextMesh> ().text;
			temp = temp + name;
			problem.GetComponent<TextMesh> ().text = temp;
		}
	}
}
