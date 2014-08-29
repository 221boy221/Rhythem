using UnityEngine;
using System.Collections;

public class WinChecker : MonoBehaviour {
    public float timeOfSong;
    public Transform donut;
    private float timer;
    private bool isFinished = false;
	void Update () {
        timer += Time.deltaTime;
        checkIfSongEnded();
	}

    void checkIfSongEnded() {
        if (timer >= timeOfSong && isFinished == false){
            Instantiate(donut, transform.position, transform.rotation);
            isFinished = true;
        }
    }
}
