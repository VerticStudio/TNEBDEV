using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheets : MonoBehaviour {

    int score = ScorDev.Score;

    public void plus100()
    {
        score = score + 100;
        ScorDev.Score = ScorDev.Score + score;
        score = 0;
    }

    public void plus1000()
    {
        score = score + 1000;
        ScorDev.Score = ScorDev.Score + score;
        score = 0;
    }

}
