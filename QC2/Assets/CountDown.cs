using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountDown : MonoBehaviour {
		//private DateTime _startTime;
		//private readonly int _limitTime = 10;
	/*public GameObject number;*/
	//private float time = 3.0f;
	public Image count;

		void Start () {
			//this._startTime = DateTime.Now;
		StartCoroutine ("CountdownCoroutine");

		}
		
		void Update () {

		 //count.text = "time";

		/*if(time >= 0.0f) time -= Time.deltaTime;

		if (time <= 3.0f  && time > 2.0f) {
			count.color = new Color(0, 0, 0);
			Debug.Log ("1");
			//Instantiate (number);

		}

		if (time <= 2.0f && time > 1.0f) {
			count.color =  new Color(0, 255, 0);
			Debug.Log ("1");
		}

		if (time <= 1.0f && time > 0.0f) {
			count.color =  new Color(0, 0, 255);
			Debug.Log ("1");
}*/

		}
	 IEnumerator CountdownCoroutine()
	{
		count.gameObject.SetActive(true);
		
		count.color = new Color(0, 0, 0);
		yield return new WaitForSeconds(1.0f);
		
		//count.text = "2";
		count.color =  new Color(255, 0, 0);
		yield return new WaitForSeconds(1.0f);
		
		//count.text = "1";
		count.color =  new Color(0, 255, 0);
		yield return new WaitForSeconds(1.0f);
		
		//count.text = "GO!";
		count.color =  new Color(0, 0, 255);
		yield return new WaitForSeconds(1.0f);
		
		//count.text = "";
		count.gameObject.SetActive(false);
	}
	}