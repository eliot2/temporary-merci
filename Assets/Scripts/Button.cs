﻿using UnityEngine;
using System.Collections;

public class Button: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI () {
		// Make a background box
		GUI.Box(new Rect(10,10,100,90), "Loader Menu");
		
		// Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
		Rect rectangle = new Rect (20, 40, 80, 20);
		if(GUI.Button(rectangle, "Level 1")) {
			Application.LoadLevel(1);
		}
		
        /*
		// Make the second button.
		if(GUI.Button(new Rect(20,70,80,20), "Level 2")) {
			Application.LoadLevel(1);
		}*/
	}
}
