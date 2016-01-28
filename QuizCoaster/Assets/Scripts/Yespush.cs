using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Yespush : MonoBehaviour {

	public Text text;
	NCMBcontroller NCMBcontroller;
	int num = 0;

	// Use this for initialization
	void Start () {
		NCMBcontroller = GetComponent<NCMBcontroller>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void push(){
		if (num == 0) {
			NCMBcontroller.LogfileSearch ();
			num++;
		}else if (num == 1) {
			NCMBcontroller.Datapush ();
			num = 0;
		}
	}
}
