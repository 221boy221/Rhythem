using UnityEngine;
using System.Collections;

public class TimeScript : MonoBehaviour {
    /* 
     * Dit script is gemaakt door Alex Antonides © - 2014.
     */
    public GUIText timeText;

    private void Awake() {
        timeText = GameObject.FindGameObjectWithTag("TimeText").GetComponent<GUIText>();
        timeText.text = "Time: " + DataClass.timeInt;
    }

    private void Update() {
        timeText.text = "Time :" + DataClass.timeInt;
    }
}
