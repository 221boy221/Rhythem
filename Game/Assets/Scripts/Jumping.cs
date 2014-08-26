using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

	public int jumpForce = 250;
	public float jumpSpeed = 3f;
	private bool onGround = true;
	
	void Update()
	{			
		//If you're on the ground you will be able to jump
		if(onGround == true)
		{
			//If W is pressed you will Jump
			if(Input.GetKeyDown(KeyCode.W))
			{
				Jump();
			}
		}
	}
	
	//Jump Physics
	void Jump()
	{
		this.transform.rigidbody2D.AddForce(Vector3.up * jumpSpeed * jumpForce);
		onGround = false;
	}
	
	//Checks if you're on the ground
	void OnCollisionEnter2D (Collision2D hit)
	{
		if(hit.transform.tag == "ground")
		{
			onGround = true;
		}
	}
}
