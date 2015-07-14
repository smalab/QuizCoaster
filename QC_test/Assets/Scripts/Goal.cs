using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

	public Text success;
	public Text congratulation;
	public Text restarttext;
	public Button restartbutton;
	public Image restartimage;
	public GameObject dungeon;
	private Animator anim;
	TrueMove TrueMove;
	
	void Start () {
		TrueMove = GetComponent<TrueMove> ();
		TrueMove.reset ();
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = true;
		success.enabled = false;
		congratulation.enabled = false;
		restarttext.enabled = false;
		restartbutton.enabled = false;
		restartimage.enabled = false;
		StartCoroutine ("move");
	}

	// unitychanを"jump"させた後"joy"させる
	IEnumerator move(){
		yield return new WaitForSeconds (1.0f);
		success.enabled = true;
		anim.SetTrigger ("jump");
		yield return new WaitForSeconds (1.2f);
		dungeon.GetComponent<dungeon> ().enabled = false;
		yield return new WaitForSeconds (0.5f);
		dungeon.GetComponent<dungeon> ().enabled = true;
		success.enabled = false;
		yield return new WaitForSeconds (7.3f);
		dungeon.GetComponent<dungeon> ().enabled = false;
		congratulation.enabled = true;
		anim.SetTrigger ("joy");
		yield return new WaitForSeconds (1.0f);
		restartbutton.enabled = true;
		restartimage.enabled = true;
		restarttext.enabled = true;
	}
}
