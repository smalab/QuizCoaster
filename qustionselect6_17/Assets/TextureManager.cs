using UnityEngine;
using System.Collections;


public class TextureManager : MonoBehaviour
{

	const string BASE_TEXTURE = "Textures/apple";
	Texture2D image;
	public GameObject go;


	void Start() {
		image = Resources.Load(BASE_TEXTURE) as Texture2D;
		//image = Resources.Load<Texture2D>(BASE_TEXTURE);
		go.GetComponent<Renderer>().GetComponent<Renderer>().material.mainTexture = image;
	}

	void Update() {

	}
}