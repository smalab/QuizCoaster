using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gyroselect : MonoBehaviour {
	
	public Image image1;
	public Image image2;
	public static string select;
	private GameObject parent1;
	private GameObject parent2;
	private GameObject child1;
	public static bool flag1;
	public bool flag2;

	// Use this for initialization
	void Start () {
		select = null;
		image1.enabled = false;
		image2.enabled = false;
		flag1 = false;
		flag2 = false;
		gyrocontroller.Ongyro();
	}
	
	// Update is called once per frame
	void Update () {
	
			if (gyrocontroller.y_gyro() < -5.0f) {
				transform.position += new Vector3 (0.01f, 0, 0);
				select = "right";
				flag2 = cursor.ok();
			}
			if (gyrocontroller.y_gyro () > 5.0f) {
				transform.position += new Vector3 (-0.01f, 0, 0);
				select = "left";
				flag2 = cursor.ok ();
			} 
			if (select != null)
				touchimage ();
	}

	public static string selecti(){
		return select;
	}

	public void touchimage () {
		if (select == "right") tag = image1.tag;
		if (select == "left") tag = image2.tag;
		if (tag == "right") flag1 = true;
		if (tag == "mistake") flag1 = false;
	}

	public static bool whichimage(){
		return flag1;
	}
	
}
