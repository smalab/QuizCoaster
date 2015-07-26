using UnityEngine;
using System.Collections;

public class MoveMe : IMoveMe {

	public Transform MoveAngleByKey(Transform _transform, Vector3 speed){
		_transform.Rotate (new Vector3 (Input.GetAxisRaw ("Vertical")*speed.x, Input.GetAxisRaw ("Horizontal")*speed.y, 0));
		return _transform;
	}

}
