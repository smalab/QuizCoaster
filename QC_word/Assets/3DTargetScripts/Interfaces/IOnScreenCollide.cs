using UnityEngine;

public interface IOnScreenCollide {

	string GetRaycastHitTag(Transform _marker);
	string GetRaycastHitName(Transform _marker);

}
