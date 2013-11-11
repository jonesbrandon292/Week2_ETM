using UnityEngine;
using System.Collections;

public class MainGameLogic : MonoBehaviour 
{
	PlayerController Player
	{
		get
		{
			GameObject gameObject = GameObject.Find("Player");
			if(gameObject == null)
				return null;
			
			return gameObject.GetComponent<PlayerController>();
		}
	}
	
	public bool GameRunning;
	protected Rect m_window_area;
	// Use this for initialization
	void Start () 
	{
		GameRunning = true;
		m_window_area = new Rect(0, 0, Screen.width, Screen.height);
	}
	
	void OnGUI()
	{
		GUILayout.BeginArea(m_window_area);
		{
			GUILayout.BeginVertical();
			
			if(GameRunning)
			{
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				GUILayout.Label("Player Lives: " + Player.playerLives);
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
			}
			else
			{
				GUILayout.FlexibleSpace();
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical();
				GUILayout.Label("Game Over");
				
				if(GUILayout.Button("Main Menu"))
				{
					Application.LoadLevel("MainMenu");
				}
				
				GUILayout.EndVertical();
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
				GUILayout.FlexibleSpace();
			}
			
			GUILayout.EndVertical();
		}
		GUILayout.EndArea();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void GameOver()
	{
		
	}
}
