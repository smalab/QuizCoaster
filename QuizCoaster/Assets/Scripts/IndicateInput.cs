using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IndicateInput : MonoBehaviour {

	public Text oktext;
	public Image okimage;
	public Text passwordtext;
	public Image passwordimage;
	public InputField inputfield;

	// Use this for initialization
	void Start () {
		oktext.enabled = false;
		okimage.enabled = false;
		passwordtext.enabled = false;
		passwordimage.enabled = false;
		inputfield.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void IndicateInputPassword(){
		oktext.enabled = true;
		okimage.enabled = true;
		passwordtext.enabled = true;
		passwordimage.enabled = true;
		inputfield.enabled = true;
		Time.timeScale = 0.0f;
	}
}