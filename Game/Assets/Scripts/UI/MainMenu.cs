﻿using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;
	
	public GUIStyle Random1;
	public GUIStyle Random2;
	
	public float guiPlacementY1;
	public float guiPlacementY2;
	
	public float guiPlacementX1;
	public float guiPlacementX2;
	
	/*void Update(){
		audio.PlayOneShot(AudioClip, "introscreenmusic");
		}*/
	
	void OnGUI(){
		//display our Background Texture
		
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
		
		//Displays our Buttons (With GUI Outline)
		/*
		if (GUI.Button (new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .5f, Screen.height * .1f), "Play Game")){
			print ("Clicked Play Game");
			Application.LoadLevel("Prototype01");
		}

		if (GUI.Button (new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .5f, Screen.height * .1f), "Quit")){
			print ("Clicked Quit");
			Application.Quit();
		}
		*/
		//Displays our Buttons (Without GUI Outline)

		if (GUI.Button (new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .3f, Screen.height * .15f), "",Random1)){
			print ("Clicked Play Again");
			Application.LoadLevel("Prototype02");
		}
		
		if (GUI.Button (new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .3f, Screen.height * .15f), "",Random2)){
			print ("Clicked Credits");
			Application.LoadLevel("Credits");
		}

	}
}
