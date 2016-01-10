using UnityEngine;
using System.Collections;

public class True : MonoBehaviour {
	
	public GameObject dungeon;
	private Animator anim;
	private float time;
	private bool flag;
	public GameObject score;
	TrueMove TrueMove;
	public AudioClip audioclip;
	AudioSource audiosource;
	
	void Start () {
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		flag = false;
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = true;
		TrueMove = GetComponent<TrueMove> ();
	}

	void Update(){
		time += Time.deltaTime;
		if ((int)time == 1 && flag == false) {
			anim.SetTrigger("jump");
			audiosource.Play ();
			flag = true;
		}
		if((int)time == 2 && flag == true){
			score.SendMessage("Addscore");
			dungeon.GetComponent<dungeon> ().enabled = false;
			flag = false;
		}
		if((int)time == 3 && flag == false){
			dungeon.GetComponent<dungeon> ().enabled = true;
			flag = true;
		}

		if ((int)time == 4 && flag == true) {
		}
	}
	void OnTriggerEnter(Collider col){
		if (col.tag == "goal") {
			dungeon.GetComponent<dungeon> ().enabled = false;
			anim.SetTrigger ("wait");
			TrueMove.move();
		}
	}
}
