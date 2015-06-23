using UnityEngine;
using System.Collections;

public class Startmove : MonoBehaviour {
	
	// unitychanが前に走る
	void Update () {
		transform.position += transform.forward * 0.07f;
	}
}
