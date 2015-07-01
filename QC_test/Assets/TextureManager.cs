using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextureManager : MonoBehaviour
{
	
	string BASE_TEXTURE = "Textures/";
	string SECOND_TEXTURE = "Textures/";
	Texture2D image1;
	Texture2D image2;
	public GameObject left;
	public GameObject right;
	public static Transform leftPosition;
	public static Transform rightPosition;
	public float x = -2.406f;
	public float y = 1.802f;
	public float z = -7.76f;
	private bool flag1;
	private bool flag2;
	public Changequestiontext Changequstiontext;
	
	
	void Start() {
		flag1 = false;
		flag2 = false;
		Changequstiontext = GetComponent<Changequestiontext> ();
		left = GameObject.CreatePrimitive (PrimitiveType.Cube);
		right = GameObject.CreatePrimitive (PrimitiveType.Cube);
		left.transform.position = new Vector3 (x, y, z);
		right.transform.position = new Vector3 (-x, y, z);
		left.transform.Rotate (0, 180, 180);
		right.transform.Rotate (0, 180, 180);
		left.transform.localScale = new Vector3(4, 4, 0.1f);
		right.transform.localScale = new Vector3 (4, 4, 0.1f);
		SphereCollider leftCollider = left.AddComponent <SphereCollider>();
		leftCollider.isTrigger = true;
		SphereCollider rightCollider = right.AddComponent <SphereCollider>();
		rightCollider.isTrigger = true;
		leftPosition = left.transform;
		rightPosition = right.transform;
		//TextRender = GetComponent<TextRender>();
		image1 = Resources.Load(BASE_TEXTURE) as Texture2D;
		image2 = Resources.Load (SECOND_TEXTURE) as Texture2D;
		//image = Resources.Load<Texture2D>(BASE_TEXTURE);
		left.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = image1;
		right.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = image2;
		
		
		
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