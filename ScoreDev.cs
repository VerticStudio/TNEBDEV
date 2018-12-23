using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDev : MonoBehaviour
{
    bool Pointgiiven = false;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag.Equals("Player"))
        {
            Pointgiiven = true;
        }
        if (Pointgiiven)
        {
            ScorDev.Score++;
        }
        gameObject.SetActive(false);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Pointgiiven = false;
    }
}
