using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class True : MonoBehaviour {
	
	public GameObject dungeon;
	private Animator anim;
	private float time;
	private bool flag;
	/*public Text se;
	public Text i1;
	public Text ka;
	public Text i2;*/
	public Text text;
	public GameObject score;
	TrueMove TrueMove;
	public AudioClip audioclip;
	AudioSource audiosource;
	
	void Start () {
		/*se.enabled = false;
		i1.enabled = false;
		ka.enabled = false;
		i2.enabled = false;*/
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		flag = false;
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = true;
		TrueMove = GetComponent<TrueMove> ();
		text.enabled = false;
	}

	void Update(){
		time += Time.deltaTime;
		if ((int)time == 1 && flag == false) {
			anim.SetTrigger("jump");
			/*se.enabled = true;
			i1.enabled = true;
			ka.enabled = true;
			i2.enabled = true;
			se.SendMessage("big");
			i1.SendMessage("big");
			ka.SendMessage("big");
			i2.SendMessage("big");*/
			audiosource.Play ();
			flag = true;
		}
		if((int)time == 2 && flag == true){
			text.enabled = true;
			score.SendMessage("Addscore");
			dungeon.GetComponent<dungeon> ().enabled = false;
			flag = false;
		}
		if((int)time == 3 && flag == false){
			dungeon.GetComponent<dungeon> ().enabled = true;
			flag = true;
		}

		if ((int)time == 4 && flag == true) {
			text.enabled = false;
			/*se.enabled = false;
			i1.enabled = false;
			ka.enabled = false;
			i2.enabled = false;*/
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
