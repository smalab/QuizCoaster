using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class True : MonoBehaviour {

	public Text label;
	public GameObject dungeon;
	private Animator anim;
	
	void Start () {
		anim = GetComponent<Animator> ();
		label.enabled = false;
		StartCoroutine ("success");
	}

	// テキストを表示しunitychanをジャンプさせる
	private IEnumerator success(){
		yield return new WaitForSeconds (1.0f);
		label.enabled = true;
		anim.SetTrigger ("jump");
		yield return new WaitForSeconds (1.2f);
		dungeon.GetComponent<dungeon> ().enabled = false;
		yield return new WaitForSeconds (0.5f);
		dungeon.GetComponent<dungeon> ().enabled = true;
		label.enabled = false;
	}
}
