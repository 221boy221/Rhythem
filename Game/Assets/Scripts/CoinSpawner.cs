using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour {

    private float movementTimer;
    public int secOmhoog = 1;
    public int secOmlaag = 1;
    public Transform coin;
    private bool amIUp = false;
    public float yTime = 0.8f;
    private float timer;

    void Update() {
        movementTimer += Time.deltaTime;
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
                timer++;
                if (timer >= secOmhoog) {
                    amIUp = true;
                    timer = 0;
                }
            }
        }
        /* Omhoog.End */

        /* Omlaag */
        if (amIUp == true){
            if ((movementTimer / secOmlaag) <= secOmlaag){
                transform.Translate(Vector3.down * yTime, Space.World);
                timer++;
                if (timer >= secOmlaag) {
                    amIUp = false;
                    timer = 0;
                }
            }
        }
        /* Omlaag.End */
    }
}
