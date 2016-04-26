using UnityEngine;
using System.Collections;

public class WallScript : MonoBehaviour 
{
	public float scrollSpeed;
	public float size;
	private Vector3 startPosition;

	void Start () 
	{
		startPosition = transform.position;
	}
		
	void Update () 
	{
		float newPosition = Mathf.Repeat (Time.time * scrollSpeed, size);
		transform.position = startPosition + Vector3.down * newPosition;
	}
		
}
