using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
    /* 
     * Dit script is gemaakt door Alex Antonides © - 2014.
     */
    private float movementSpeed = 0.1f;

    private float xMin = -3f;
    private float xMax = 3f;

	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > xMin){
            transform.Translate(Vector3.left * movementSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < xMax){
            transform.Translate(Vector3.right * movementSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.up * movementSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.down * movementSpeed);
        }
	}
}