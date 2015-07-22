/*using UnityEngine;
using System.Collections;

public class TrueMove : MonoBehaviour {
	
	static public int y = 0;

	void Start () {

	}

	public static void reset(){
		y = 0;
	}

	// dungeonをunitychanの方向に動かしてunitychanが走っているように見せ次のsceneに遷移する
	public static void move(){
		if (y <= 3) {
			QuestionSelect.Up (y);
			y++;
		} else {
			Application.LoadLevel ("Goal");
			QuestionSelect.Initialization ();
			reset ();
			//Application.LoadLevel ("LastQuestion");
		}
	}
}*/

using UnityEngine;
using System.Collections;

public class TrueMove : MonoBehaviour {
	
	public GameObject dungeon;
	public static int countnumber = 0; //"Goal"のsceneに遷移するために何回問題を答えたか数える
	private Animator anim;
	
	void Start () {
		/*anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = true;
		StartCoroutine ("move");*/
	}
	
	public static void reset(){
		countnumber = 0;
	}
	
	// dungeonをunitychanの方向に動かしてunitychanが走っているように見せ次のsceneに遷移する
	public static void move(){
		/*yield return new WaitForSeconds (7.0f);
		dungeon.GetComponent<dungeon> ().enabled = false;
		anim.SetTrigger ("wait");
		yield return new WaitForSeconds (1.0f);
		//if (y < 2) {*/
		
		QuestionSelect.Up (0);
		countnumber++;
		Debug.Log ("countnumberrrrrrrrrr " + countnumber);
		/*} else {
			QuestionSelect.Initialization ();
			reset ();
			Application.LoadLevel ("LastQuestion");
		}*/
	}
}