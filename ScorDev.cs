using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ScorDev : MonoBehaviour
{

    public static int Score = 0;
    Text Text1;

    private void Start()
    {
        Score = 0;
        Text1 = GetComponent<Text>();
    }

    void Update()
    {
        Text1.text = "Score: " + Score;
    }
}