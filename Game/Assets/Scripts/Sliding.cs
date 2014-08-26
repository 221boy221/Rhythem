using UnityEngine;
using System.Collections;

public class Sliding : MonoBehaviour {
	public float speed = 0.2f;
	
	void Update () 
	{
		if (Input.GetKey (KeyCode.S)) 
		{
			this.transform.Translate(Vector3.right * speed);
		}
	}
}
