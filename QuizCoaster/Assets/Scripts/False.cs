using UnityEngine;
using System.Collections;

public class False : MonoBehaviour {

	public GameObject dungeon;
	private Animator anim;
	public GameObject bucket;
	public AudioClip audioclip;
	AudioSource audiosource;
	[SerializeField]
	Animator mAnimator; // InspectorでAnimatorを指定しておく

	
	void Start () {
		audiosource = gameObject.GetComponent<AudioSource> ();
		audiosource.clip = audioclip;
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = false;
		bucket.GetComponent<Hitbucket> ().enabled = true;
		audiosource.PlayOneShot (audioclip);
		Instantiate (bucket, new Vector3 (transform.position.x, transform.position.y + 5, transform.position.z - 1), Quaternion.identity);
	}

	void Update(){
		AnimatorStateInfo stateInfo = mAnimator.GetCurrentAnimatorStateInfo(0);
		if (stateInfo.IsName ("Running@loop")) {
			dungeon.GetComponent<dungeon> ().enabled = true;
		}
	}

	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "bucket_a_pref(Clone)") {
			anim.SetTrigger ("lose");
			anim.SetTrigger ("run");
			dungeon.GetComponent<dungeon> ().enabled = false;
		}
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "goal") {
			dungeon.GetComponent<dungeon> ().enabled = false;
			anim.SetTrigger ("wait");
			TrueMove.move ();
		}
	}
}
