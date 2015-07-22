using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Hundredhide : MonoBehaviour {

	public Text hundred;

	// Use this for initialization
	void Start () {
		hundred.text = " +100";
	}
	
	// Update is called once per frame
	void Update () {
		hundred.enabled = false;
	}
}
