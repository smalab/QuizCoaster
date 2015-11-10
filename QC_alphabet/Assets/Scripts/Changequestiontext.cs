using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Changequestiontext : MonoBehaviour {

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

//	public GameObject problem;

	// Use this for initialization
	void Start () {
		GameObject.Find ("problem").GetComponent<Text>().text = "Please select ";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static void Change(string name){
	
		alphabetget = alphabet.TryGetValue(name, out value);
		Debug.Log ("aaaaaaaaaaaaaaaaaaaaaaaaaaaa" + value);
		/*if (alphabetget == true)
				{
text [textindex] = value;
				}else{*/
		GameObject problem = GameObject.Find ("problem");
		string temp = problem.GetComponent<Text>().text;
		//Debug.Log ("aaaaaaaaa" + name);
		temp = temp + value;
		problem.GetComponent<Text> ().text = temp;

	}
}
