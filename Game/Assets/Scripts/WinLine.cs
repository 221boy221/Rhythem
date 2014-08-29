using UnityEngine;
using System.Collections;

public class WinLine : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D wall) {
        if (wall.gameObject.tag == "deathWall") {
            Destroy(gameObject);
        }

        if (wall.gameObject.tag == "Player") {
            Destroy(wall.gameObject);
            DataClass.scoreInt = 0;
            Application.LoadLevel("MainMenu");
        }
    }
}
