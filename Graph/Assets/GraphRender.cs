using UnityEngine;
using System.Collections;
using System.IO;
using System.Text;

public class GraphRender : MonoBehaviour {

	StreamReader m_reader;
	Stream stream = File.OpenRead("Assets/log.csv"); 
	string num;
	// Use this for initialization
	void Start () {
		m_reader = new StreamReader(stream, Encoding.UTF8);
	}
	
	// Update is called once per frame
	void Update () {
		while (m_reader.Peek() >= 0) {
			num = m_reader.Read ().ToString();
			Debug.Log (num);
		}	
		m_reader.Close();
	}
}
