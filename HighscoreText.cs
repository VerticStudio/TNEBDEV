using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighscoreText : MonoBehaviour {
    public Text text;
    public int Highscore = PlayerPrefs.GetInt("highscore", 0);
    private void Awake()
    {
       
    }

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "High Score: " + Highscore;
    }
}
