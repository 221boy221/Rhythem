using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //Movement
	public float speed = 0.1f;
	private float xMin = -8f;
	private float xMax = 8f;
    //Jumping
    public int jumpForce = 250;
    public float jumpSpeed = 3f;
    private bool onGround = true;
	
	void Update () {
        Movement();
        Jumping();
	}

    private void Movement() {
        if (Input.GetKey(KeyCode.A) && transform.position.x > xMin) {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x < xMax) {
            transform.Translate(Vector3.right * speed);
        }
    }

    private void Jumping() {
        // If W is pressed and player is onGround
        if (Input.GetKeyDown(KeyCode.W) && onGround == true) {
            //Jump Physics
            this.transform.rigidbody2D.AddForce(Vector3.up * jumpSpeed * jumpForce);
            onGround = false;
        }
    }

    //Checks if you're on the ground
    private void OnCollisionEnter2D(Collision2D hit) {
        if (hit.transform.tag == "ground") {
            onGround = true;
        }
    }

}