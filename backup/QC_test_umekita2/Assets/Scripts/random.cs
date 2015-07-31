using UnityEngine;
using System.Collections;

public class random : MonoBehaviour {
	
	static int[] data;
	public int num;
	public static int questionnumber; //SelectControllerスクリプトに問題の個数を参照させるための変数
	public static int number; // ランダムで出力したい数字の末尾の1個後(number = 4なら0~3の数字が重複なしでランダムにでる)
	private int i = 0;
	static int x;
	static public int randomnumber;
	
	// Use this for initialization
	void Start () {
		questionnumber = num; 
		number = num;
		data = new int[number];
		initialization();
		/*x = Random.Range(0, number);
		randomnumber = data [x];
		Debug.Log("data " + data[x]);
		fill ();
		number--;*/
	}
	
	// Update is called once per frame
	void Update () {
	}

	public static int Randomnumber(){
		x = Random.Range(0, number);
		randomnumber = data [x];
		Debug.Log("data " + data[x]);
		fill ();
		number--;
		return randomnumber;
	}
	
	public void initialization() {
		while(i < number){
			data[i] = i++;
		}
	}
	
	public static void fill(){
		while (x < number - 1) data [x] = data [++x];
	}
}

