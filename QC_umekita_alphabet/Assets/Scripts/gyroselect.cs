using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gyroselect : MonoBehaviour {
	
	//public Image image1;
	//public Image image2;
	public static string select;
	private GameObject parent1;
	private GameObject parent2;
	private GameObject child1;
	public static bool flag1;
	public bool flag2;
	TextureManager TextureManager;

	// Use this for initialization
	void Start () {
		TextureManager = GetComponent<TextureManager> ();
		select = null;
		/*image1.enabled = false;
		image2.enabled = false;*/
		flag1 = false;
		flag2 = false;
		gyrocontroller.Ongyro();
	}
	
	// Update is called once per frame
	void Update () {
	
			if (gyrocontroller.y_gyro() < -1.0f) {
				//transform.position += new Vector3 (0.01f, 0, 0);
			Debug.Log ("right");
				select = "right";
				flag2 = cursor.ok();
			}
			if (gyrocontroller.y_gyro () > 1.0f) {
				//transform.position += new Vector3 (-0.01f, 0, 0);
				select = "left";
				flag2 = cursor.ok ();
			} 
			if (flag2 == true)
				touchimage ();
	}

	public static string selecti(){
		return select;
	}

	public void touchimage () {
		if (select == "right") tag = TextureManager.right.tag;
		if (select == "left") tag = TextureManager.left.tag;
		if (tag == "seikai") flag1 = true;
		if (tag == "mistake") flag1 = false;
	}

	public static bool whichimage(){
		return flag1;
	}
	
}
