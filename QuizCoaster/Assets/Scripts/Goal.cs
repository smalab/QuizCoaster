using UnityEngine;
using System.Collections;

public class Goal : MonoBehaviour {

	public GameObject target;
	public GameObject dungeon;
	private Animator anim;
	public TextMesh text;
	public GameObject score;
	public AudioClip clear_bgm;
	public AudioClip right_se;
	public AudioClip mistake_se;
	AudioSource audiosource;
	GameObject BGM;
	
	void Start () {
		BGM = GameObject.Find ("BGM");
		audiosource = gameObject.GetComponent<AudioSource> ();
		target.gameObject.SetActive(false);
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = true;
		StartCoroutine ("move");
	}

	// unitychanを"jump"させた後"joy"させる
	IEnumerator move(){
		yield return new WaitForSeconds (1.0f);
		if (SelectController.truefalse == "right") {
			audiosource.clip = right_se;
			audiosource.Play();
			anim.SetTrigger("right");
			dungeon.GetComponent<dungeon> ().enabled = false;
			yield return new WaitForSeconds (1.5f);
			dungeon.GetComponent<dungeon> ().enabled = true;
			score.SendMessage("Addscore");
			yield return new WaitForSeconds (4.0f);
			text.text = "";
		} else {
			audiosource.clip = mistake_se;
			audiosource.Play();
			anim.SetTrigger("mistake");
			dungeon.GetComponent<dungeon> ().enabled = false;
			yield return new WaitForSeconds (3.5f);
			dungeon.GetComponent<dungeon> ().enabled = true;
			text.text = "";
		}
		yield return new WaitForSeconds (4.0f);
		target.gameObject.SetActive(true);
		text.text = "<size=45><color=#FFFFFFFF> さいごに家の絵を見ておわってね</color></size>"; 
		yield return new WaitForSeconds (6.0f);
		audiosource.Stop ();
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "goal") {
			text.text = "<size=100><color=#1CD1FFFF>ゴール!</color></size>";
			Destroy (BGM);
			audiosource.clip = clear_bgm;
			audiosource.Play();
			dungeon.GetComponent<dungeon> ().enabled = false;
			anim.SetTrigger ("goal");
			score.SendMessage("Center");
		}
	}
}
