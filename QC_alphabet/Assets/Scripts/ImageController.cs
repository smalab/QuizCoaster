using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ImageController : MonoBehaviour {

	public Image rightimage;
	public Image mistakeimage;
	public Button rightbutton;
	public Button mistakebutton;
	
	void Start () {
		rightbutton.enabled = false;
		mistakebutton.enabled = false;
	}
	
	// imageが完全に表示されるまで押せないようにする
	void Update () {
		rightimage.fillAmount += 0.03f;
		mistakeimage.fillAmount += 0.03f; 
		if (rightimage.fillAmount >= 1.0f && mistakeimage.fillAmount >= 1.0f) {
			rightbutton.enabled = true;
			mistakebutton.enabled = true;
		}
	}
}
