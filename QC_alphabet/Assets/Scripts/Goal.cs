using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Goal : MonoBehaviour {

	public MeshRenderer target;
	public GameObject dungeon;
	private Animator anim;
	public Text text;
	public GameObject score;
	public AudioClip audioclip;
	AudioSource audiosource;
	GameObject BGM;

	
	void Start () {
		BGM = GameObject.Find ("BGM");
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		target.enabled = false;
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = true;
		StartCoroutine ("move");
	}

	// unitychanを"jump"させた後"joy"させる
	IEnumerator move(){
		yield return new WaitForSeconds (1.0f);
		if (SelectController.truefalse == "right") {
			text.text = "<size=50><color=#FF4545FF>せいかい!</color></size>";
			yield return new WaitForSeconds (1.0f);
			score.SendMessage("Addscore");
			yield return new WaitForSeconds (4.0f);
			text.text = "";
		} else {
			text.text = "<size=50><color=#00FF80FF>ちがうよ!</color></size>"; 
			yield return new WaitForSeconds (5.0f);
			text.text = "";
		}
		yield return new WaitForSeconds (1.0f);
		text.text = "<size=50><color=#1CD1FFFF>ゴール!</color></size>";
		Destroy (BGM);
		audiosource.Play ();
		yield return new WaitForSeconds (2.0f);
		target.enabled = true;
		text.text = "<size=39><color=#FFFFFFFF> さいごに家の絵を見ておわってね</color></size>"; 
		yield return new WaitForSeconds (6.0f);
		audiosource.Stop ();
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "goal") {
			dungeon.GetComponent<dungeon> ().enabled = false;
			anim.SetTrigger ("joy");
			score.SendMessage("Center");
		}
	}
}
