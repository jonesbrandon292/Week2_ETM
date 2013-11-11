using UnityEngine;
using System.Collections;

public class MainGameLogic : MonoBehaviour 
{
	PlayerController Player
	{
		get
		{
			GameObject gameObject = GameObject.FindGameObjectWithTag("Player");
			if(gameObject == null)
				return null;
			
			return gameObject.GetComponent<PlayerController>();
		}
	}
	
	//GameObjects
	public GameObject m_player_template;
	public GameObject m_cube_obstacle;
	public GameObject m_cylinder_obstacle;
	
	public bool GameRunning;
	protected Rect m_window_area;
	// Use this for initialization
	void Start () 
	{
		GameRunning = true;
		m_window_area = new Rect(0, 0, Screen.width, Screen.height);
		
		Quaternion playerRotation = Quaternion.identity;
		playerRotation.SetLookRotation(new Vector3(90, 0, 0));
		GameObject.Instantiate(m_player_template, new Vector3(-16, 1, 0), playerRotation);
		
		//Spawning Cubes
		GameObject obs = (GameObject)GameObject.Instantiate(m_cube_obstacle, new Vector3(-10, 0, -20), Quaternion.identity);
		CubeObstacleLogic cubeObsLogic = obs.GetComponent<CubeObstacleLogic>();
		if(cubeObsLogic != null)
			cubeObsLogic.MoveDirection = -1;
		
		obs = (GameObject)GameObject.Instantiate(m_cube_obstacle, new Vector3(0, 0, 20), Quaternion.identity);
		cubeObsLogic = obs.GetComponent<CubeObstacleLogic>();
		if(cubeObsLogic != null)
			cubeObsLogic.MoveDirection = 1;
		
		obs = (GameObject)GameObject.Instantiate(m_cube_obstacle, new Vector3(5, 0, -20), Quaternion.identity);
		cubeObsLogic = obs.GetComponent<CubeObstacleLogic>();
		if(cubeObsLogic != null)
			cubeObsLogic.MoveDirection = -1;
		
		obs = (GameObject)GameObject.Instantiate(m_cube_obstacle, new Vector3(10, 0, 20), Quaternion.identity);
		cubeObsLogic = obs.GetComponent<CubeObstacleLogic>();
		if(cubeObsLogic != null)
			cubeObsLogic.MoveDirection = 1;
		
		obs = (GameObject)GameObject.Instantiate(m_cube_obstacle, new Vector3(15, 0, -20), Quaternion.identity);
		cubeObsLogic = obs.GetComponent<CubeObstacleLogic>();
		if(cubeObsLogic != null)
			cubeObsLogic.MoveDirection = -1;
		//
		
		
		//Spawning Cylinders
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(-5, -5, -5), Quaternion.identity);
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(-5, -5, 0), Quaternion.identity);
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(-5, -5, 5), Quaternion.identity);
		
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(2.5f, -5, -5), Quaternion.identity);
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(2.5f, -5, 0), Quaternion.identity);
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(2.5f, -5, 5), Quaternion.identity);
		
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(7.5f, -5, -5), Quaternion.identity);
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(7.5f, -5, 0), Quaternion.identity);
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(7.5f, -5, 5), Quaternion.identity);
		
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(12.5f, -5, -5), Quaternion.identity);
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(12.5f, -5, 0), Quaternion.identity);
		obs = (GameObject)GameObject.Instantiate(m_cylinder_obstacle, new Vector3(12.5f, -5, 5), Quaternion.identity);
		//
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
				{
					if(Player != null)
						GUILayout.Label("Player Lives: " + Player.playerLives);
				}
				GUILayout.FlexibleSpace();
				GUILayout.EndHorizontal();
			}
			else
			{
				GUILayout.FlexibleSpace();
				GUILayout.BeginHorizontal();
				GUILayout.FlexibleSpace();
				GUILayout.BeginVertical();
				{
					GUILayout.Label("Game Over");
					
					if(GUILayout.Button("Main Menu"))
					{
						Application.LoadLevel("MainMenu");
					}
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
