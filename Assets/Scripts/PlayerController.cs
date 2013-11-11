using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	MainGameLogic GameLogic
	{
		get
		{
			GameObject gameObject = GameObject.Find("MainGameObject");
			if(gameObject == null)
				return null;
			
			return gameObject.GetComponent<MainGameLogic>();
		}
	}
	
	Vector3 startPosition;
	public int playerLives;
	// Use this for initialization
	void Start () 
	{
		playerLives = 3;
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(transform.position.y < startPosition.y - 5)
			KillPlayer();
	}
	
	public void KillPlayer()
	{
		--playerLives;
		
		if(playerLives > 0)
		{
			transform.position = startPosition;
			return;
		}
		
		GameLogic.GameRunning = false;
		Destroy(gameObject);
	}
	
	void OnControllerColliderHit(ControllerColliderHit other)
	{
		if(other.gameObject.tag == "Obstacle")
		{
			BaseObstacleLogic obs = other.gameObject.GetComponent<BaseObstacleLogic>();
			obs.HandleCollision(transform);
		}
	}
}
