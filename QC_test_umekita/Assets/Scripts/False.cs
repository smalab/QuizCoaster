using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class False : MonoBehaviour {

	public GameObject dungeon;
	private Animator anim;
	public GameObject bucket;
	private float time;
	private bool flag;
	public GameObject za;
	public GameObject n1;
	public GameObject ne;
	public GameObject n2;
	public AudioClip audioclip;
	AudioSource audiosource;
	
	void Start () {
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
		if ((int)time == 7 && flag == true) {
			dungeon.GetComponent<dungeon> ().enabled = true;
			flag = false;
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
