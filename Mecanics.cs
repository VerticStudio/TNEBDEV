﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mecanics : MonoBehaviour {

    public float movementSpeed = 10;

    void Update () {
        transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
    }
}
