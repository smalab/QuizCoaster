using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Count : MonoBehaviour {
	//private DateTime _startTime;
	//private readonly int _limitTime = 10;
	/*public GameObject number;*/
	//private float time = 3.0f;
	public Image count;

public IEnumerator CountdownCoroutine(){
		count.gameObject.SetActive(true);
		
		count.color = new Color(0, 0, 0);
		yield return new WaitForSeconds(1.0f);
		

		count.color =  new Color(255, 0, 0);
		yield return new WaitForSeconds(1.0f);
		

		count.color =  new Color(0, 255, 0);
		yield return new WaitForSeconds(1.0f);
		

		count.color =  new Color(0, 0, 255);
		yield return new WaitForSeconds(1.0f);
		
		count.gameObject.SetActive(false);
	}
}