using UnityEngine;
using System.Collections;

public class MainMenuLogic : MonoBehaviour 
{
	protected Rect m_window_area;
	
	// Use this for initialization
	void Start () 
	{
		//Camera.current.
		
		m_window_area = new Rect(0, 0, Screen.width, Screen.height);
	}
	
	void OnGUI()
	{
		
		GUILayout.BeginArea(m_window_area);
		{
			GUILayout.FlexibleSpace();
			GUILayout.BeginVertical();
			{
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				GUILayout.Label("Super Game");
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
				
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				if(GUILayout.Button("Play"))
				{
					Application.LoadLevel("MainGame");
				}
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
			}
			GUILayout.EndVertical();
			GUILayout.FlexibleSpace();
		}
		GUILayout.EndArea();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
