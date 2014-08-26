using UnityEngine;
using System.Collections;

public class ButtonsMovement : MonoBehaviour {
   /* 
    * Dit script is gemaakt door Alex Antonides © - 2014.
    */
    private float movementSpeed = 0.05f;

	void Update () {
        transform.Translate(Vector3.left * movementSpeed);
	}

    void OnTriggerEnter2D(Collider2D player) {
        if (player.gameObject.tag == "line") {
            renderer.material.color = Color.green;
        }
    }

    void OnTriggerExit2D(Collider2D player) {
        renderer.material.color = Color.red;
    }
}
