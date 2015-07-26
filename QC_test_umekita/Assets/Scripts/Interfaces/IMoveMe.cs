using UnityEngine;

public interface IMoveMe {
	// change speed.x to 0 if you want to disable x rotation
	Transform MoveAngleByKey(Transform _transform, Vector3 speed);
}
