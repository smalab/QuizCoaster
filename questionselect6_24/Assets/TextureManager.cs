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
	public int x = 10;
	public int y = 0;



	void Start() {
		left = GameObject.CreatePrimitive (PrimitiveType.Cube);
		right = GameObject.CreatePrimitive (PrimitiveType.Cube);
		left.transform.position = new Vector3 (x, y, 0);
		right.transform.position = new Vector3 (-x, y, 0);
		left.transform.Rotate (0, 180, 0);
		right.transform.Rotate (0, 180, 0);
		left.transform.localScale = new Vector3(1, 1, 0.1f);
		right.transform.localScale = new Vector3(1, 1, 0.1f);
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
		Debug.Log ("l_name" + l_name);
		BASE_TEXTURE += l_name;
		Debug.Log ("BASE " + BASE_TEXTURE);
		//BASE_TEXTURE = "Textures/apple";
		Debug.Log ("BASE " + BASE_TEXTURE);
		image1 = Resources.Load(BASE_TEXTURE) as Texture2D;
		left.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = image1;
	}

	public void RightTexture(string r_name) {
		SECOND_TEXTURE += r_name;
		image2 = Resources.Load(SECOND_TEXTURE) as Texture2D;
		right.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = image2;
	}

	public void LeftTag(string l_tag){
		left.tag = (l_tag);
	}

	public void RightTag(string r_tag){
		Debug.Log ("righttag");
		right.tag = (r_tag);
	}

}