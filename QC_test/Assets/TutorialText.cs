using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Tutorialtext : MonoBehaviour {
	
	private bool flag;
	public string[] scenarios;
	[SerializeField] Text uiText;
	
	[SerializeField][Range(0.001f, 0.3f)]
	float intervalForCharacterDisplay = 0.05f;
	
	private string currentText = string.Empty;	// 現在の文字列
	private float timeUntilDisplay = 0;		// 表示にかかる時間
	private float timeElapsed = 1;			// 文字列の表示を開始した時間
	private int lastUpdateCharacter = -1;		// 表示中の文字数
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		int displayCharacterCount = (int)(Mathf.Clamp01((Time.time - timeElapsed) / timeUntilDisplay) * currentText.Length);
		
		// 表示文字数が前回の表示文字数と異なるならテキストを更新する
		if( displayCharacterCount != lastUpdateCharacter ){
			uiText.text = currentText.Substring(0, displayCharacterCount);
			lastUpdateCharacter = displayCharacterCount;
		}
	}
	
	public void Neutral(){
		currentText = scenarios [0] + "\n" + scenarios [1];
		
		// 想定表示時間と現在の時刻をキャッシュ
		timeUntilDisplay = currentText.Length * intervalForCharacterDisplay;
		timeElapsed = Time.time;
		
		// 文字カウントを初期化
		lastUpdateCharacter = -1;
	}
	
	public void Play(){
		currentText = scenarios [2] + "\n" + scenarios [1];
		
		// 想定表示時間と現在の時刻をキャッシュ
		timeUntilDisplay = currentText.Length * intervalForCharacterDisplay;
		timeElapsed = Time.time;
		
		// 文字カウントを初期化
		lastUpdateCharacter = -1;
	}
	
	public void Tutorial(){
		currentText = scenarios [3] + "\n" + scenarios [0];
		
		// 想定表示時間と現在の時刻をキャッシュ
		timeUntilDisplay = currentText.Length * intervalForCharacterDisplay;
		timeElapsed = Time.time;
		
		// 文字カウントを初期化
		lastUpdateCharacter = -1;
	}
}
