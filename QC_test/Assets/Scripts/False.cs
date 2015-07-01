using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class False : MonoBehaviour {

	public Text label;
	public Button restart;
	public Image image;
	public Text button;
	public GameObject dungeon;
	private Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
		label.enabled = false;
		restart.enabled = false;
		image.enabled = false;
		button.enabled = false;
		dungeon.GetComponent<dungeon> ().enabled = true;
		StartCoroutine ("miss");
	}

	// textを表示しunitychanを"lose"にする
	private IEnumerator miss(){
		yield return new WaitForSeconds (4.0f);
		label.enabled = true;
		dungeon.GetComponent<dungeon> ().enabled = false;
		anim.SetTrigger ("lose");
		yield return new WaitForSeconds (2.5f);
		label.enabled = false;
		image.enabled = true;
		restart.enabled = true;
		button.enabled = true;
		QuestionSelect.Initialization ();
		yield break;
	}

}
