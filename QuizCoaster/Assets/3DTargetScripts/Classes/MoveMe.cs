using UnityEngine;
using System.Collections;

public class MoveMe : IMoveMe {

	public Transform MoveAngleByKey(Transform _transform, Vector3 speed){
		_transform.Rotate (new Vector3 (Input.GetAxisRaw ("Vertical")*speed.x, Input.GetAxisRaw ("Horizontal")*speed.y, 0));
		return _transform;
	}

	public Transform MoveAngleByHead(Transform _transform, Vector3 speed, Gyroscope gyro){
		if (!gyro.enabled) {
			throw new UnityException ("Gyro not enabled");
		}
		_transform.Rotate (new Vector3 (-gyro.rotationRate.x*speed.x, -gyro.rotationRate.y*speed.y, 0));
		return _transform;
	}

}