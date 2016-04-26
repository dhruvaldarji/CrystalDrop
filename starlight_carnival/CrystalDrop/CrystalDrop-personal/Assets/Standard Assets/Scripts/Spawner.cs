using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	
	public GameObject platform;      
	public float spawnTime = 3f; 
	public Transform[] spawnPoints;


	void Start ()
	{
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn ()
	{

		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
		Instantiate (platform, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}