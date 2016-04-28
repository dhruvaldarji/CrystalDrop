using UnityEngine;
using System.Collections;

public class TiltMovement : MonoBehaviour {
		
	public float moveSpeed = 1f;

		void Update () 
		{
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (-moveSpeed, 0, 0);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (moveSpeed, 0, 0);
		}
		transform.Translate((Input.acceleration.x)*2, 0, 0);
		}
	}