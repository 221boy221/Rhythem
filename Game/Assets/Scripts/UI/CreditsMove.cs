using UnityEngine;
using System.Collections;

public class CreditsMove : MonoBehaviour {

	public float speed = 0.04f;

	// Update is called once per frame
    private void Update() {
		transform.Translate (Vector2.up * speed);

		if (this.transform.position.y > 11)
		{
			Application.LoadLevel("MainMenu");
		}
	}
}
