using UnityEngine;
using System.Collections;

public class BaseObstacleLogic : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
	public void HandleCollision(Transform player)
	{
		PlayerController playerControl = player.GetComponent<PlayerController>();
		playerControl.KillPlayer();
	}
}
