using UnityEngine;
using System.Collections;

public class CylinderObstacleLogic : MonoBehaviour 
{
	public int MoveDirection = 1;
	float moveSpeed = 30;
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
		
		if(MoveDirection > 0)
			transform.Translate(0, moveSpeed * Time.deltaTime, 0);
		else
			transform.Translate(0, MoveDirection * (moveSpeed * 0.25f) * Time.deltaTime, 0);
		
		if(MoveDirection > 0 && transform.position.y > 1.5)
		{
			MoveDirection = -MoveDirection;	
		}
		else if(MoveDirection < 0 && transform.position.y < -1.5)
		{
			sleeping = true;
			sleepStart = Time.time;
			sleepCurDuration = sleepBaseDuration + Random.Range(0.0f, sleepBaseDuration);
		}
	}
}
