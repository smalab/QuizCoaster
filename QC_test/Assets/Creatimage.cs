using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Creatimage : MonoBehaviour {

	public Image image;

	// Use this for initialization
	void Start () {
		Instantiate (image, new Vector3 (0, 0, 0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
