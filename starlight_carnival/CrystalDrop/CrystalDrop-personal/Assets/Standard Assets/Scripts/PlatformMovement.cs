using UnityEngine;
using System.Collections;

public class PlatformMovement : MonoBehaviour {

	public float lifetime = 10f;
	public float scrollSpeed;
	public float platSpeed = 1;
	public GameObject platform;

	// Use this for initialization
	void Start () 
	{
		Object.Destroy (platform, lifetime);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.timeScale != 0) {
			platform.transform.Translate (0, platSpeed, 0);
		}
	}
}
