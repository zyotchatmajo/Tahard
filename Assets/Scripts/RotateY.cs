﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class RotateY : MonoBehaviour {
    float rotateY = .5f;
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(0, rotateY, 0);
    }


}
