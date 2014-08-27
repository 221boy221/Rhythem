using UnityEngine;
using System.Collections;

public class CoinMovement : MonoBehaviour {
    /* 
     * Dit script is gemaakt door Alex Antonides © - 2014.
     */
    [SerializeField] private float movementSpeed = 0.1f;

    void Update() {
        transform.Translate(Vector3.left * movementSpeed);
	}

    void OnCollisionEnter2D(Collision2D player) {
        if (player.gameObject.tag == "Player") {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D wall) {
        if (wall.gameObject.tag == "deathWall") {
            Destroy(gameObject);
        }
    }
}
