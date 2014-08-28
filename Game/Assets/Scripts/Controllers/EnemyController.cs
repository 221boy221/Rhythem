using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    private float speed;
    [SerializeField] private float speedMin = 0.1f;
    [SerializeField] private float speedMax = 0.3f;

    void Start() {
        speed = Random.Range(speedMin, speedMax);
    }

	void Update () {
        transform.Translate(Vector3.left * speed);
	}

    void OnTriggerEnter2D(Collider2D wall) {
        if (wall.gameObject.tag == "deathWall") {
            Destroy(gameObject);
        }

        if (wall.gameObject.tag == "Player") {
            Destroy(wall.gameObject);
        }
    }
}
