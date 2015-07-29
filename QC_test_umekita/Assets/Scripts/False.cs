using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class False : MonoBehaviour {

	public GameObject dungeon;
	private Animator anim;
	public GameObject bucket;
	private float time;
	private bool flag;
	public Text za;
	public Text n1;
	public Text ne;
	public Text n2;
	public AudioClip audioclip;
	AudioSource audiosource;
	
	void Start () {
		za.enabled = false;
		n1.enabled = false;
		ne.enabled = false;
		n2.enabled = false;
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		flag = false;
		time = 0.0f;
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = true;
		bucket.GetComponent<Hitbucket> ().enabled = true;
	}

	void Update(){
		time += Time.deltaTime;
		if ((int)time == 3 && flag == false) {
			Instantiate (bucket, new Vector3 (transform.position.x, transform.position.y + 4, transform.position.z - 1), Quaternion.identity);
			za.enabled = true;
			n1.enabled = true;
			ne.enabled = true;
			n2.enabled = true;
			za.SendMessage("down");
			n1.SendMessage("down");
			ne.SendMessage("down");
			n2.SendMessage("down");
			audiosource.PlayOneShot (audioclip);
			anim.SetTrigger ("lose");
			anim.SetTrigger ("run");
			dungeon.GetComponent<dungeon> ().enabled = false;
			flag = true;
		}
		/*if ((int)time == 5 && flag == true) {
			za.enabled = false;
			n1.enabled = false;
			ne.enabled = false;
			n2.enabled = false;
			flag = false;
		}*/
		if ((int)time == 7 && flag == true) {
			dungeon.GetComponent<dungeon> ().enabled = true;
			za.enabled = false;
			n1.enabled = false;
			ne.enabled = false;
			n2.enabled = false;
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "goal") {
			dungeon.GetComponent<dungeon> ().enabled = false;
			anim.SetTrigger ("wait");
			TrueMove.move ();
			//QuestionSelect.Up (TrueMove.y++);
		}
	}
}
