using UnityEngine;
using System.Collections;

public class TextureInitilize : MonoBehaviour {

	string Left_TEXTURE = "Difficulty/";
	string Right_TEXTURE = "Difficulty/";
	Texture2D Left_Image;
	Texture2D Right_Image;
	GameObject left;
	GameObject right;
	public static Transform leftPosition;
	public static Transform rightPosition;
	private float x2 = -8.23f;
	private float x1 = -2.88f;
	private float y = 2.09f;
	private float z = -10.26f;
	private bool flag1;
	private bool flag2;
	// Use this for initialization
	void Start () {
		left = GameObject.CreatePrimitive (PrimitiveType.Plane);
		right = GameObject.CreatePrimitive (PrimitiveType.Plane);
		left.name = "leftplane";
		right.name = "rightplane";
		right.transform.position = new Vector3 (x1, y, z);
		left.transform.position = new Vector3 (x2, y, z);
		right.transform.Rotate (90, -90, 90);
		left.transform.Rotate (90, -90, 90);
		right.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
		left.transform.localScale = new Vector3 (0.4f, 0.4f, 0.4f);
		SphereCollider rightCollider = right.AddComponent <SphereCollider>();
		rightCollider.isTrigger = true;
		rightCollider.radius = 3.5f;
		SphereCollider leftCollider = left.AddComponent <SphereCollider>();
		leftCollider.isTrigger = true;
		leftCollider.radius = 3.5f;
		rightPosition = right.transform;
		leftPosition = left.transform;
		Left_Image = Resources.Load(Left_TEXTURE + "easy") as Texture2D;
		Right_Image = Resources.Load(Right_TEXTURE + "hard") as Texture2D;
		right.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = Right_Image;
		left.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = Left_Image;
		left.tag = "easy";
		right.tag = "hard";
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
