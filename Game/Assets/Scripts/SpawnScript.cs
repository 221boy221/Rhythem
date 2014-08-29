using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {
    /* 
     * Dit script is gemaakt door Alex Antonides © - 2014.
     */
    private float soldierSpawnTime;
    [SerializeField] private int tMin = 5;
    [SerializeField] private int tMax = 15;
    private int randomTimer;

    public CameraShake cameraShake;
    public GameObject MainCamera;

    public Transform soldier;

    private void Start() {
        randomTimer = Random.Range(tMin, tMax);
        GameObject MainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        cameraShake = MainCamera.GetComponent<CameraShake>(); 
    }

    private void Update() {
        soldierSpawnTime += Time.deltaTime;

        SpawnSoldier();
	}

    private void SpawnSoldier() {
        if (soldierSpawnTime >= randomTimer) {
            Instantiate(soldier, transform.position, transform.rotation);
            soldierSpawnTime = 0;
            randomTimer = Random.Range(tMin, tMax);
            cameraShake.Shake();
        }
    }

}
