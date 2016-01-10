using UnityEngine;
using System.Collections;

public class CourierController : MonoBehaviour {

	private Animator anim;
	DifficultyCursor DifficultyCursor;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		DifficultyCursor = GetComponent<DifficultyCursor>();
	}
	
	// Update is called once per frame
	void Update () {
		if (DifficultyCursor.rank () == "go")
			anim.SetTrigger ("go");
	}
}
