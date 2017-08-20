using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenreMananger : MonoBehaviour {

    string actionLevel = "actionLevel";
    string adventureLevel = "adventureLevel";
    string romanceLevel = "romanceLevel";
    string comedyLevel = "comedyLevel";



    // Use this for initialization
    void Start () {

        PlayerPrefs.SetInt("actionLevel", 1);
        PlayerPrefs.SetInt("adventureLevel", 1);
        PlayerPrefs.SetInt("romanceLevel", 1);
        PlayerPrefs.SetInt("comedyLevel", 1);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
