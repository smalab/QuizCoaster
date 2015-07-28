using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour {

	public GameObject left;
	public GameObject right;
	public Image play;
	public Image tutorial;
	public Text p_text;
	public Text t_text;
	Renderer l_ren;
	Renderer r_ren;
	private Quaternion q;
	private float time;
	//public GameObject p_anim;
	//public GameObject t_anim;
	public GameObject text;
	private bool flag;
	//public GameObject quetion;

	// Use this for initialization
	void Start () {
		flag = false;
		play.enabled = false;
		tutorial.enabled = false;
		p_text.enabled = false;
		t_text.enabled = false;
		l_ren = left.GetComponent<Renderer> ();
		r_ren = right.GetComponent<Renderer> ();
		time = 0.0f;
		Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
			q = Input.gyro.attitude;
			q.y *= -1.0f;
			if (q.y < -0.5f) {
			if(flag == true){
				flag = false;
				text.SendMessage ("Tutorial");
			}
				tutorial.enabled = true;
				//t_anim.SendMessage ("Appearance");
				t_text.enabled = true;
				l_ren.enabled = true;
				r_ren.enabled = false;
				time += Time.deltaTime;
			} else if (q.y < -0.35) {
			if(flag == false){
				flag = true;
				text.SendMessage ("Neutral");
			}
				//t_anim.SendMessage ("Exit");
				//p_anim.SendMessage ("Exit");
				//tutorial.enabled = false;
				//play.enabled = false;
				//t_text.enabled = false;
				//p_text.enabled = false;
				//l_ren.enabled = true;
				//r_ren.enabled = true;
				time = 0;
		} else {
			if(flag == true){
				flag = false;
				text.SendMessage ("Play");
			}
				play.enabled = true;
				//p_anim.SendMessage ("Appearance");
				//p_text.enabled = true;
				//l_ren.enabled = false;
				//r_ren.enabled = true;
				time += Time.deltaTime;
			if(time > 5.0f) QuestionSelect.StartUp();
			}
			//Debug.Log ("time " + time);
		}
}
