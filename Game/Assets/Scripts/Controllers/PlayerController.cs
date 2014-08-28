using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //Movement
	[SerializeField] private float speed = 0.1f;
	private float xMin = -7f;
	private float xMax = 7f;
    //Jumping
    [SerializeField] private int jumpForce = 250;
    [SerializeField] private float jumpSpeed = 3f;
    private bool onGround = true;
	
	void Update () {
        Movement();
        Jumping();
	}

    private void Movement() {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= xMin || Input.GetKey(KeyCode.A) && transform.position.x >= xMin) {
            transform.Translate(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x <= xMax || Input.GetKey(KeyCode.D) && transform.position.x <= xMax) {
            transform.Translate(Vector3.right * speed);
        }
    }

    private void Jumping() {
        if (Input.GetKeyDown(KeyCode.W) && onGround == true || Input.GetKey(KeyCode.UpArrow) && onGround == true) {
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