﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubemovement : MonoBehaviour
{
    float speed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position = transform.position + move * speed * Time.deltaTime;
    }
}
