using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour {
    private int sceneint = 1;
    public string cheets;

    public void ChangeMenuScene()
    {
        Application.LoadLevel(sceneint);
    }

    public void Lol(String newval)
    {
        if(newval == "000.WWW.no")
        {
            sceneint = 2;

        }
        if (newval == "000.WWW.yes")
        {
            sceneint = 3;

        }
    }
}

