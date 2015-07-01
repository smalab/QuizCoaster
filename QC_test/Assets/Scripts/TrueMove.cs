using UnityEngine;
using System.Collections;

public class TrueMove : MonoBehaviour {

	public GameObject dungeon;
	public static int y = 0;
	private Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = true;
		StartCoroutine ("move");
	}

	public static void reset(){
		y = 0;
	}

	// dungeonをunitychanの方向に動かしてunitychanが走っているように見せ次のsceneに遷移する
	IEnumerator move(){
		yield return new WaitForSeconds (7.0f);
		dungeon.GetComponent<dungeon> ().enabled = false;
		anim.SetTrigger ("wait");
		yield return new WaitForSeconds (1.0f);
		//if (y < 2) {

			QuestionSelect.Up (y++);
		Debug.Log ("yyyyyyy " + y);
			//y++;
		/*} else {
			QuestionSelect.Initialization ();
			reset ();
			Application.LoadLevel ("LastQuestion");
		}*/
	}
}
