﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbstractCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // this gets the x and z pos of the camera per each frame 
        float x = GameObject.Find("Main Camera").transform.position.x;
        float z = GameObject.Find("Main Camera").transform.position.z;

        if (!( x >= 160 && x <= 240 && z >= -120 && z <= 120))
        {
            //transports the text to some place that the user cannot see 
            transform.position = new Vector3(1000, 1000, 1000); 
        }
        else
        {
            //allows the user to see the text when the user is in the exhibit
            transform.position = new Vector3(218, 101, 192.0519f); 
        }

        

    }
}
