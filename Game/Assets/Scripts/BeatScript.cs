using UnityEngine;
using System.Collections;

public class BeatScript : MonoBehaviour {

    private float timer = 0;
    private float movementTimer = 1;
    public Transform coin;
    private float yTime = 0.6f;
    private bool check = false;
    private bool spawnMore = false;
    private int timingTime = 0;
    private float archTimer = 0;
    private float archLength = 5;

    void Update() {
        float[] spectrum = audio.GetSpectrumData(1024, 0, FFTWindow.BlackmanHarris);
        int i = 1;
        float highest = 0f;

        while (i < 1023) {
            i++;
            if (spectrum[i] > highest) {
                highest = spectrum[i];
            }
        }

        if (highest > 0.12f) {
            SpawnTheCoins(); // Roep functie aan op de beat
        }

        timer += Time.deltaTime;
        movementTimer += Time.deltaTime;
    }

    private void SpawnTheCoins() {
        if (timer >= 15) {
            spawnMore = true;
            SpawnArch();
        } else {
            StartCoroutine(SpawnCoinz());
        }
    }

    public void SpawnCoin() {
        Instantiate(coin, transform.position, transform.rotation);
    }

    IEnumerator SpawnCoinz() {
        yield return new WaitForSeconds(0.03f);
        SpawnCoin();
        StopAllCoroutines();
    }

    public void SpawnArch() {
        if (check == false && spawnMore == true) {
            for (int i = 0; i <= 3; i++) {
                Instantiate(coin, transform.position, transform.rotation);
                transform.Translate(Vector3.up * yTime, Space.World);
                if (transform.localPosition.y >= -0.8) {
                    check = true;
                    spawnMore = false;
                    timingTime++;
                }
            }
        } else if (check == true && spawnMore == true) {
            for (int j = 0; j <= 3; j++) {
                Instantiate(coin, transform.position, transform.rotation);
                transform.Translate(Vector3.down * yTime, Space.World);
                if (transform.localPosition.y <= -2)
                    timer = 0;
                spawnMore = false;
                check = false;
            }
        } else if (check == true && spawnMore == false) {
            archTimer += Time.deltaTime;
            if (archTimer >= archLength) {
                spawnMore = true;
            }
            for (int k = 0; k <= 3; k++) {
                Instantiate(coin, transform.position, transform.rotation);
            }
        }

    }
}