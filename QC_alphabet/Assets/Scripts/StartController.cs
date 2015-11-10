using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartController : MonoBehaviour {
	
	private Animator anim;
	private bool flag = true;  // moveクラスを1回だけ呼び出すための判定
	private int x;
	public Button screenbutton;
	public Text screentext;
	public GameObject dungeon;

	void Start () {
		anim = GetComponent<Animator> ();
		dungeon.GetComponent<dungeon> ().enabled = false;
		gameObject.GetComponent<Startmove> ().enabled = false;

	}
	
	// moveクラスを1回だけ呼び出す
	void Update () {
		if (Touchscreen.touch () == true) {
			if (flag == true) {
				screenbutton.enabled = false;
				screentext.enabled = false;
				StartCoroutine ("move");
				flag = false;
			}
		}
	}

	// unitychanを少し前に移動させ止めてからdungeonを動かしてunitychanを走らせているように見せる
	IEnumerator move(){
		yield return new WaitForSeconds (3.0f);
		anim.SetTrigger ("touch");
		yield return new WaitForSeconds (1.0f);
		gameObject.GetComponent<Startmove> ().enabled = true;
		yield return new WaitForSeconds (0.7f);
		gameObject.GetComponent<Startmove> ().enabled = false;
		dungeon.GetComponent<dungeon> ().enabled = true;
		yield return new WaitForSeconds (6.9f);
		dungeon.GetComponent<dungeon> ().enabled = false;
		anim.SetTrigger ("wait");
		yield return new WaitForSeconds (0.5f);
		QuestionSelect.StartUp ();
	}
}
