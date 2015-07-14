using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	//private static bool created = false;
	Addscore Addscore;
	//public static int score = 0;
	// Use this for initialization
	//public GameObject score;
	public static int score = 0;
	public Text n;
	/*void Awake(){
		//if(!created){
			// シーンを切り替えても指定のオブジェクトを破棄せずに残す
			DontDestroyOnLoad(n);
			// 生成した
			//created = true;
		//} else {
			//Destroy(n);
		//}
	}*/

	void Start () {
		Add ();
		GameObject.Find ("scoretext").GetComponent<Text>().text = "Score ";
		GameObject scoretext = GameObject.Find ("scoretext");
		string temp = scoretext.GetComponent<Text>().text;
		temp += score.ToString ();
		scoretext.GetComponent<Text> ().text = temp;
		//Addscore = GetComponent<Addscore> ();
		//Addscore.Reset ();


	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Add(){
		score += 100;
	}
	
	public static void Reset(){
		score = 0;
	}
}
