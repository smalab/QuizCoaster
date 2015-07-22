using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Scorecontroller : MonoBehaviour {

	public static int score;
	//public static Text hundred;
	public static int i = 0;
	public GameObject hundred;

	// Use this for initialization
	void Start () {
		hundred.GetComponent<Hundredhide>().enabled = true;
		hundred.GetComponent<Hundredappearance>().enabled = false;
		GetComponent<Text>().text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void Addscore(){
		StartCoroutine("Addition");
	}

	private IEnumerator Addition(){
		GetComponent<Text>().text = score.ToString();
		hundred.GetComponent<Hundredhide>().enabled = true;
		yield return new WaitForSeconds (1);
		hundred.GetComponent<Hundredappearance>().enabled = true;
		while (i < 50) {
			score += 2;
			i++;
			GetComponent<Text> ().text = score.ToString ();
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
