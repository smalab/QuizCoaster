using UnityEngine;
using System.Collections;

public class OnScreenCollide : IOnScreenCollide {

	public string GetRaycastHitTag(Transform _marker){
		Vector3 _position = Camera.main.WorldToScreenPoint (_marker.position); 
		Ray ray = Camera.main.ScreenPointToRay(_position);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {
			return hit.collider.tag;
		} else {
			return null;
		}
	}

	public string GetRaycastHitName(Transform _marker){
		Vector3 _position = Camera.main.WorldToScreenPoint (_marker.position); 
		Ray ray = Camera.main.ScreenPointToRay(_position);
		RaycastHit hit;
		//Debug.Log (hit.collider.name);
		if (Physics.Raycast (ray, out hit)) {
			return hit.collider.name;
		} else {
			return null;
		}
	}
}
