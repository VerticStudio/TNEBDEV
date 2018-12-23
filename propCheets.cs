using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propcheets : MonoBehaviour
{

    public void Plus100()
    {
        Scor.Score = Scor.Score + 100;
        Scor.Score = Scor.Score + Scor.Score;
        Scor.Score = 0;
    }

    public void Plus1000()
    {
        Scor.Score = Scor.Score + 1000;
        Scor.Score = Scor.Score + Scor.Score;
        Scor.Score = 0;

    }
}
