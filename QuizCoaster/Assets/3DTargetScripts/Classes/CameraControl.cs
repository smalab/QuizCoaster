using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

using System.Collections;

public class CameraControl : MonoBehaviour {

	IMoveMe _moveMe;
//	RaycastHit hit;
	Gyroscope gyro;

	void Start ()
	{
		if (SystemInfo.supportsGyroscope) {
			gyro = Input.gyro;
			gyro.enabled = true;
		}
	}

	// Use this for initialization

	public void Initialize(IMoveMe _moveMe){
		if (_moveMe == null) {
			throw new UnityException ("_moveMe is null");
		}
		this._moveMe = _moveMe;
	}

	void Update () {
		if (gyro == null) {
			_moveMe.MoveAngleByKey (transform, new Vector3 (1f, 1f, 0));

		} else {
			_moveMe.MoveAngleByHead (transform, new Vector3 (1f, 1f, 0), gyro);
		}

//		if(Physics.Raycast(transform.position,Vector3.forward+transform.rotation.eulerAngles,out hit))
//		{
//			//Debug.Log (hit.collider.tag);
//
////			if(hit.collider.tag == "Player" )
////			{
////				Debug.Log( "前方に見える" );
////			}
//		} 

	}
}
