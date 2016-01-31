using UnityEngine;
using System.Collections;

public class TrueMove : MonoBehaviour {
	
	public GameObject dungeon;
	public static int countnumber = 0; //"Goal"のsceneに遷移するために何回問題を答えたか数える
	private Animator anim;
	
	void Start () {

	}
	
	public static void reset(){
		countnumber = 0;
	}
	

	public static void move(){
		QuestionSelect.Up (0);
		countnumber++;
	}
}