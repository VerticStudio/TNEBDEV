using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PlayerPrefs.SetInt("highscore", 0);
        PlayerPrefs.Save();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
