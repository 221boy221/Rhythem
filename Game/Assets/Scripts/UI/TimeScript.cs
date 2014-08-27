using UnityEngine;
using System.Collections;

public class TimeScript : MonoBehaviour {
    /* 
     * Dit script is gemaakt door Alex Antonides © - 2014.
     */
    public GUIText timeText;

    void Awake() {
        timeText = GameObject.FindGameObjectWithTag("TimeText").GetComponent<GUIText>();
        timeText.text = "Time: " + DataClass.timeInt;
    }

    void Update() {
        timeText.text = "Time :" + DataClass.timeInt;
    }
}
