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

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            Destroy(gameObject);
            DataClass.scoreInt++;
        } else if (other.gameObject.tag == "deathWall") {
            Destroy(gameObject);
            if (DataClass.scoreInt < 100) {
                DataClass.scoreInt -= 3;
            } else if (DataClass.scoreInt < 500) {
                DataClass.scoreInt -= 6;
            } else {
                DataClass.scoreInt -= 12;
            }
            
            if (DataClass.scoreInt < 0) {
                Destroy(other.gameObject);
                DataClass.scoreInt = 0;
                Application.LoadLevel("GameOver");
            }
        }
    }

}
