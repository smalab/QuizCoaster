using UnityEngine;
using System.Collections;
using System;


/// <summary>
/// テキストデータの読み込みをして一文字ずつ判断して処理するクラス
/// </summary>
/// <remarks>
/// プロジェクト名/Assetsフォルダにプロジェクト名/Assets/Resourcesフォルダを生成し、
/// その中でプロジェクト名/Assets/Resources/textフォルダを生成しプロジェクト名/Assets/Resources/text/text.textを置く。
/// </remarks>
public class TextRender : MonoBehaviour {

	/// <summary>
	/// テキストデータのパス
	/// </summary>
	private string filePath = "";
	/// <summary>
	/// 読み込んだテキストデータを格納するテキストアセット
	/// </summary>
	public TextAsset stageTextAsset;
	/// <summary>
	/// ステージの文字列データ
	/// </summary>
	public string stageData;
	public string[] text;
	public string data;
	TextureManager TextureManager;
	//QuestionSelect QuestionSelect;
	//public GameObject image1;
	//public GameObject image2;
	public bool flag;
	/// <summary>
	/// ステージの文字列データの添え字
	/// </summary>
	public int stageDataIndex = 0;
	public int textindex = 0;
	public int num;
	/// <summary>
	/// 抽出した文字を格納する変数
	/// </summary>
	public char pattern;
	/// <summary>
	/// 待ち時間
	/// </summary>
	private float waitingTime;
	private int enternumber;
	/// <summary>
	/// 初期化
	/// </summary>
	/// <remarks>
	/// テキストデータの読み込み
	/// </remarks>
	void Start () {
		if(DifficultyCursor.difficulty == "easy") filePath = "text/umekita_alphabet";
		if(DifficultyCursor.difficulty == "hard") filePath = "text/umekita_word";
		// テキストデータの読み込み
		TextureManager = GetComponent<TextureManager> ();
		//QuestionSelect = GetComponent<QuestionSelect> ();
		text = new string[100];
		flag = false;
		num = 0;
		enternumber = random.Randomnumber ();
		ReadTextData();
	}
	/// <summary>
	/// 毎フレームごとの処理
	/// </summary>
	/// <remarks>
	/// ステージデータから一文字ずつ抽出して比較する。
	/// </remarks>
	void Update () {
		// フレーム増加
		waitingTime += Time.deltaTime;
		// もしも65フレーム経って、なおかつ全部出し切っていなければ。
		if (/*waitingTime >= Time.deltaTime*100 && flag == false && stageDataIndex != stageData.Length*/num < 4) {
			//while(pattern != '\n'){
			//QuestionSelect.x -= 1;

			while (enternumber > 0) {
				EnterTextData ();
				enternumber--;
			}

			waitingTime = 0.0f;
			// 文字の抽出
			pattern = stageData [stageDataIndex];
			Debug.Log ("pattern " + pattern);
			if(pattern == '\n') 		Debug.Log ("enenu");
			if (pattern == '\t' || pattern == '\n') {
				if(pattern == '\n') 		Debug.Log ("enenu");
				if(pattern == '\t') 		Debug.Log ("tab");
				flag = true;
				
				if (flag == true && num == 0) {
					data = string.Join (null, text);
					Debug.Log ("num0 " + data);
					TextureManager.LeftTag (data);
					text = new string[100];
					data = "";
					num++;
					flag = false;
				}
				if (flag == true && num == 1) {
					data = string.Join (null, text);
					Debug.Log ("num1 " + data);
					TextureManager.LeftTexture (data);
					text = new string[100];
					data = "";
					num++;
					flag = false;
				}
				if (flag == true && num == 2) {
					data = string.Join (null, text);
					Debug.Log ("num2 " + data);
					TextureManager.RightTag (data);
					text = new string[100];
					data = "";
					num++;
					flag = false;
					Debug.Log ("num " + num);
				}
				if (flag == true && num == 3) {
					data = string.Join (null, text);
					Debug.Log ("num3 " + data);
					TextureManager.RightTexture (data);
					text = new string[100];
					data = "";
					num++;
					Debug.Log ("finalnum " + num);
					flag = false;
				}
			}else if (pattern != '\t' || pattern != '\n') {

				text [textindex] = pattern.ToString ();

				Debug.Log ("text " + text [textindex]);
				textindex++;
				// 文字の比較
			}
			stageDataIndex++;
		}
	}
	/// <summary>
	/// テキストデータの読み込み。
	/// </summary>
	/// <remarks>
	/// テキストデータを読み込み、読み込んだテキストデータをステージデータに格納し、空白を削除する
	/// </remarks>
	void ReadTextData(){
		// TextAssetとして、Resourcesフォルダからテキストデータをロードする
		stageTextAsset = Resources.Load(filePath) as TextAsset;
		// 文字列を代入
		stageData = stageTextAsset.text;
		// 空白を置換で削除
		//stageData = stageData.Replace(" ", "");
	}

	void EnterTextData(){
		pattern = stageData [stageDataIndex];
		Debug.Log ("pattern " + pattern);
		while (pattern != '\n') {
			pattern = stageData [stageDataIndex++];
			Debug.Log ("pattern " + pattern);
		}
		//stageDataIndex++;
	}
}