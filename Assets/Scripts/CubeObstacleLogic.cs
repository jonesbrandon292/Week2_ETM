using UnityEngine;
using System.Collections;

public class CubeObstacleLogic : BaseObstacleLogic 
{
	public int MoveDirection = 1;
	float moveSpeed = 15;
	bool sleeping;
	float sleepBaseDuration = 1.0f;
	float sleepCurDuration;
	float sleepStart;
	// Use this for initialization
	void Start () 
	{
		sleeping = true;
		sleepStart = Time.time;
		sleepCurDuration = sleepBaseDuration + Random.Range(0.0f, sleepBaseDuration);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(sleeping)
		{
			if(Time.time >= sleepStart + sleepCurDuration)
			{
				sleeping = false;
				MoveDirection = -MoveDirection;
			}
			return;
		}
		
		transform.Translate(0, 0, MoveDirection * moveSpeed * Time.deltaTime);
		
		if((MoveDirection > 0 && transform.position.z > 20) || 
			(MoveDirection < 0 && transform.position.z < -20))
		{
			sleeping = true;
			sleepStart = Time.time;
			sleepCurDuration = sleepBaseDuration + Random.Range(0.0f, sleepBaseDuration);
		}
	}
}
