using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

[CustomEditor(typeof(OriginalInspector))]
public class OriginalInspectorEditor : Editor
{
	private List<float> data_ = new List<float>();
	
	override public void OnInspectorGUI()
	{
		EditorGUILayout.Space();
		
		if (Application.isPlaying) {
			AddData (Random.Range(0.0f, 5.0f));
		}
		
		var area = GUILayoutUtility.GetRect(Screen.width, 200f);
		
		// Grid
		const int div = 10;
		for (int i = 0; i <= div; ++i) {
			var lineColor = (i == 0 || i == div) ? Color.white : Color.gray;
			var lineWidth = (i == 0 || i == div) ? 2f : 1f;
			var x = (area.width  / div) * i;
			var y = (area.height / div) * i;
			Drawing.DrawLine (
				new Vector2(area.x + x, area.y),
				new Vector2(area.x + x, area.yMax), lineColor, lineWidth, true);
			Drawing.DrawLine (
				new Vector2(area.x,    area.y + y),
				new Vector2(area.xMax, area.y + y), lineColor, lineWidth, true);
		}
		
		// Data
		if (data_.Count > 0) {
			var max = data_.Max();
			var dx  = area.width / data_.Count; 
			var dy  = area.height / max;
			Vector2 previousPos = new Vector2(area.x, area.yMax); 
			for (var i = 0; i < data_.Count; ++i) {
				var x = area.x + dx * i;
				var y = area.yMax - dy * data_[i];
				var currentPos = new Vector2(x, y);
				Drawing.DrawLine(previousPos, currentPos, Color.red, 3f, true);
				previousPos = currentPos;
			}
		}
		
		EditorGUILayout.Space();
	}
	
	private void AddData(float value)
	{
		data_.Add(value);
		if (data_.Count > 100) {
			data_.RemoveAt(0);
		}
	}
}