using UnityEngine;
using System.Collections;

public class CoinSpawnScript : MonoBehaviour {

    public Transform coin;

    IEnumerator WaitAndPrint() {
        yield return new WaitForSeconds(5);
        print("WaitAndPrint " + Time.time);
    }
    public IEnumerator SpawnCoin() {
        print(Time.time);
        yield return new WaitForSeconds(1);
        print(Time.time);
        Instantiate(coin, transform.position, transform.rotation);
    }

}
