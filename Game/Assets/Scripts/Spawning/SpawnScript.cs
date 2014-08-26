using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    /* 
     * Dit script is gemaakt door Alex Antonides © - 2014.
     */
    private float spawnTime;
    private float archTime;
    private float spawningTime;

    private bool isArch = false;
    private bool spawnArch = false;

    private int numberUp = 0;
    private int randomNumber;

    private float timeSpawn= 0.8f;

    public Transform coin;

	void Update () {
        spawnTime += Time.deltaTime;
        archTime += Time.deltaTime;
        spawningTime += Time.deltaTime;

        randomNumber = Random.Range(10, 30);

        SpawnCoin();
        CreateArch();
        SpawnArch();
	}

    void SpawnCoin() {
        if (isArch == false) {
            if (spawnTime >= 0.5) {
                Instantiate(coin, transform.position, transform.rotation);
                spawnTime = 0;
            }
        }
    }

    void CreateArch() {
        if (archTime >= randomNumber) {
            isArch = true;
            spawnArch = true;
            archTime = 0;
        }
    }

    void SpawnArch() {
        if (spawnArch) {
            if (numberUp <= 4)
            {
                if (spawningTime >= 0.3) {
                    Instantiate(coin, transform.position, transform.rotation);
                    transform.Translate(Vector3.up * timeSpawn, Space.World);
                    numberUp++;
                    spawningTime = 0;
                }
            }
            if (numberUp >= 4) {
                if (spawningTime >= 0.3) {
                    Instantiate(coin, transform.position, transform.rotation);
                    transform.Translate(Vector3.down * timeSpawn, Space.World);
                    spawningTime = 0;
                    numberUp++;
                }
            }
            if (numberUp >= 10) {
                numberUp = 0;
                isArch = false;
                spawnArch = false;
            }
        }
    }
}
