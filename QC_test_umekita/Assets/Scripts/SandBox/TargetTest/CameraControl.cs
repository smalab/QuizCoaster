using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

using System.Collections;

public class CameraControl : MonoBehaviour {

	IMoveMe _moveMe;
	RaycastHit hit;

	// Use this for initialization
	void Start () {
		_moveMe = new MoveMe ();
	}
	
	// Update is called once per frame
	void Update () {
		_moveMe.MoveAngleByKey (transform, new Vector3(1f,1f,0));

		if(Physics.Raycast(transform.position,Vector3.forward+transform.rotation.eulerAngles,out hit))
		{
			//Debug.Log (hit.collider.tag);

//			if(hit.collider.tag == "Player" )
//			{
//				Debug.Log( "前方に見える" );
//			}
		} 

	}
}
