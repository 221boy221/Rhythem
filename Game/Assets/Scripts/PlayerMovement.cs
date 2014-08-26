using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed = 0.1f;
	private float xMin = -8;
	private float xMax = 8;
	
	void Update () 
	{
		if (Input.GetKey (KeyCode.A) && transform.position.x > xMin) 
		{
			transform.Translate(Vector3.left * speed);
		}
		if (Input.GetKey (KeyCode.D)  && transform.position.x < xMax) 
		{
			transform.Translate(Vector3.right * speed);
		}
	}
}
