using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text;

public class Nopush : MonoBehaviour {

	public Text text;
	public Text yestext;
	public Image yesimage;
	public Text notext;
	public Image noimage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void push(){
		Debug.Log ("no");
		text.text = "アプリを終了してください";
		yestext.enabled = false;
		yesimage.enabled = false;
		notext.enabled = false;
		noimage.enabled = false;
	}
}
