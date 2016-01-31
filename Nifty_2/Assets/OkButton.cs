using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OkButton : MonoBehaviour {
	
	Datapull datapull;
	// Use this for initialization
	void Start () {
		datapull = GetComponent <Datapull>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void push(){
		datapull.pull = true;
	}
}
