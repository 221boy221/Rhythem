using UnityEngine;
using System.Collections;
using System;

public class DataClass : MonoBehaviour {
    /* 
     * Dit script is gemaakt door Alex Antonides © - 2014.
     */
	public static int timeInt;
    public static int scoreInt;

    public static float timeFloat;

	void Awake(){
		DontDestroyOnLoad (gameObject);
	}
	
	void Update (){
        timeFloat += Time.deltaTime;
        timeInt = Convert.ToInt32(timeFloat);
	}
}