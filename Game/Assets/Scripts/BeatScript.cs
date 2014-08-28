using UnityEngine;
using System.Collections;

public class BeatScript : MonoBehaviour {
    private bool isArch = false;
    public int timerMax = 1;
    public int timerMin = 1;
    private int ArchTimer;
    private float timer;
    private float movementTimer;
    public int secOmhoog = 1;
    public int secOmlaag = 1;
    public Transform coin;
    private bool amIUp = false;
    public float yTime = 0.8f;
    private float tTimer;

    void Start() {
        ArchTimer = Random.Range(timerMin, timerMax);
    }

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
            print("SpawnCoin");
        }
        timer += Time.deltaTime;
        movementTimer += Time.deltaTime;

        //IsArchCheck();
    }

    void IsArchCheck() {
        if (timer >= ArchTimer) {
            isArch = true;
            timer = 0;
        }
    }

    void SpawnTheCoins() {
        // Als de Arch NIET word gemaakt, dan blijft het script de coins spawnen. (Zie SpawnScript)
        if (isArch == false) {
            SpawnCoin();
        }
        // Als de Arch word gemaakt, dan gaat de spawner omhoog en omlaag. (Zie SpawnScript)
        if (isArch == true) {
            SpawnArch();

            if (timer >= (secOmhoog += secOmlaag)) {
                isArch = false;
            }
        }
    }

    public void SpawnCoin() {
        Instantiate(coin, transform.position, transform.rotation);
    }

    public void SpawnArch() {
        Instantiate(coin, transform.position, transform.rotation);

        /* Omhoog */
        if (amIUp == false) {
            if ((movementTimer / secOmhoog) <= secOmhoog) {
                transform.Translate(Vector3.up * yTime, Space.World);
                tTimer++;
                if (tTimer >= secOmhoog) {
                    amIUp = true;
                    tTimer = 0;
                }
            }
        }
        /* Omhoog.End */

        /* Omlaag */
        if (amIUp == true) {
            if ((movementTimer / secOmlaag) <= secOmlaag) {
                transform.Translate(Vector3.down * yTime, Space.World);
                tTimer++;
                if (tTimer >= secOmlaag) {
                    amIUp = false;
                    tTimer = 0;
                }
            }
        }
        /* Omlaag.End */
    }
}