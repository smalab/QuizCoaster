using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

	/*public Text success;
	public Text congratulation;
	public Text restarttext;
	public Button restartbutton;
	public Image restartimage;*/
	public GameObject dungeon;
	private Animator anim;
	public Text se;
	public Text i1;
	public Text ka;
	public Text i2;
	public GameObject za;
	public GameObject n1;
	public GameObject ne;
	public GameObject n2;
	public Transform camera;

	
	void Start () {
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = true;
		StartCoroutine ("move");
		/*success.enabled = false;
		congratulation.enabled = false;
		restarttext.enabled = false;
		restartbutton.enabled = false;
		restartimage.enabled = false;
		StartCoroutine ("move");*/
	}

	// unitychanを"jump"させた後"joy"させる
	IEnumerator move(){
		yield return new WaitForSeconds (1.0f);
		if (SelectController.truefalse == "right") {
			se.SendMessage ("big");
			i1.SendMessage ("big");
			ka.SendMessage ("big");
			i2.SendMessage ("big");
		} else {
			za.SendMessage ("down");
			n1.SendMessage ("down");
			ne.SendMessage ("down");
			n2.SendMessage ("down");
		}
		/*yield return new WaitForSeconds (1.0f);
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
		restarttext.enabled = true;*/
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "goal") {
			dungeon.GetComponent<dungeon> ().enabled = false;
			anim.SetTrigger ("joy");
		}
	}
}
