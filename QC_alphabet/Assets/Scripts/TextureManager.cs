using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextureManager : MonoBehaviour
{

	string BASE_TEXTURE = "alphabet/";
	string SECOND_TEXTURE = "alphabet/";
	Texture2D image1;
	Texture2D image2;
	public GameObject left;
	public GameObject right;
	public static Transform leftPosition;
	public static Transform rightPosition;
	private float x2 = -8.23f;
	private float x1 = -2.88f;
	private float y = 2.09f;
	private float z = -10.26f;
	private bool flag1;
	private bool flag2;
	public Changequestiontext Changequstiontext;
	
	
	void Start() {
		flag1 = false;
		flag2 = false;
		Changequstiontext = GetComponent<Changequestiontext> ();
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
		//TextRender = GetComponent<TextRender>();
		image2 = Resources.Load(BASE_TEXTURE) as Texture2D;
		image1 = Resources.Load (SECOND_TEXTURE) as Texture2D;
		//image = Resources.Load<Texture2D>(BASE_TEXTURE);
		right.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = image1;
		left.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = image2;
		
		
		
	}
	
	void Update() {
		
	}
	
	public void LeftTexture(string l_name) {
		if (flag1 == true)
			Changequestiontext.Change (l_name);
		Debug.Log ("l_name" + l_name);
		BASE_TEXTURE += l_name;
		Debug.Log ("BASE " + BASE_TEXTURE);
		//BASE_TEXTURE = "Textures/apple";
		Debug.Log ("BASE " + BASE_TEXTURE);
		image1 = Resources.Load(BASE_TEXTURE) as Texture2D;
		left.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = image1;
	}
	
	public void RightTexture(string r_name) {
		if (flag2 == true)
			Changequestiontext.Change (r_name);
		SECOND_TEXTURE += r_name;
		image2 = Resources.Load(SECOND_TEXTURE) as Texture2D;
		right.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = image2;
	}
	
	public void LeftTag(string l_tag){
		if (l_tag == "right")
			flag1 = true;
		left.tag = (l_tag);
	}
	
	public void RightTag(string r_tag){
		if (r_tag == "right")
			flag2 = true;
		right.tag = (r_tag);
	}

}