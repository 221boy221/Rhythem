using UnityEngine;
using System.Collections;

public class ScoreScript : MonoBehaviour {
    /* 
     * Dit script is gemaakt door Alex Antonides © - 2014.
     */
    public GUIText timeText;

    void Awake() {
        timeText = GameObject.FindGameObjectWithTag("ScoreBoard").GetComponent<GUIText>();
        timeText.text = "Score: " + DataClass.scoreInt;
    }

    void Update() {
        timeText.text = "Score :" + DataClass.scoreInt;
    }
}