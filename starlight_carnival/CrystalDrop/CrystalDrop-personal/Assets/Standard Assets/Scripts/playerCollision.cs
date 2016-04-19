using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class playerCollision : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D other)
	{
		print ("hit");
		SceneManager.LoadScene (0);
	}
}
