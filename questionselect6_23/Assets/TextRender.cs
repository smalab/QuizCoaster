﻿using UnityEngine;
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
	private string filePath = "text/test";
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
	public GameObject image1;
	public GameObject image2;
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
	/// <summary>
	/// 初期化
	/// </summary>
	/// <remarks>
	/// テキストデータの読み込み
	/// </remarks>
	void Start () {
		// テキストデータの読み込み
		TextureManager = GetComponent<TextureManager> ();
		text = new string[100];
		flag = false;
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
	if(/*waitingTime >= Time.deltaTime*100 && */flag == false && stageDataIndex != stageData.Length){
			waitingTime = 0.0f;
			// 文字の抽出
			pattern = stageData[stageDataIndex];
			text[textindex] =  pattern.ToString ();
			Debug.Log("text " + text[textindex]);
			// 文字の比較
			if(pattern == '\t'){
				if(num == 0){
					TextRender.Texture(image1);
				}
				data = string.Join (null, text);
				image1.tag = (data);

				//Debug.Log("text" + text);
			} else if(pattern == '\n'){
				Debug.Log("\n");
				flag = true;
			} else if(pattern == '2'){
				Debug.Log("pattern:2");
			}
			// 次へ
			stageDataIndex++;
			textindex++;
		}


		Debug.Log ("data " + data);
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
		stageData = stageData.Replace(" ", "");
	}
}