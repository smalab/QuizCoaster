﻿using UnityEngine;
using System.Collections;

public class QuestionSelect : MonoBehaviour {

	static int x;
	static int[] data = new int[3];
	static int i;
	static bool flag;
	static int length;

	void Start(){
		flag = false;
		length = data.Length;
	}
	
	public static void StartUp(){
		x = Random.Range (1, 4);
		data [0] = x;
		Application.LoadLevel (x);
	}
		
	public static void Up(int k) {
		while (flag == false) {
			x = Random.Range (1, 4);
			i = 0;
			while (i <= k) {
				if (data [i] == x)
					break;
				if (data [i] != x && data [i + 1] == 0) {
					data [i + 1] = x;
					flag = true;
				}
				i++;
			}
		}
		Application.LoadLevel (x);
	}

	public static void Initialization(){
		for (int i = 0; i < length; i++)
			data [i] = 0;
	}
}