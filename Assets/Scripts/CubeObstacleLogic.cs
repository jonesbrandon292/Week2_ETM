using UnityEngine;
using System.Collections;

public class CubeObstacleLogic : BaseObstacleLogic 
{
	int moveDirection = 1;
	float moveSpeed = 10;
	float collisionForce = 50;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(0, 0, moveDirection * moveSpeed * Time.deltaTime);
		
		if((moveDirection > 0 && transform.position.z > 20) || 
			(moveDirection < 0 && transform.position.z < -20))
		{
			moveDirection = -moveDirection;
		}
	}
}
