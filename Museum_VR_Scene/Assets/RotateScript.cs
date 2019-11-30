using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        var rotationDir = new Vector3(horizontal, 0, vertical);
        transform.rotation = 
            Quaternion.LookRotation(rotationDir, Vector3.up); 

    }
}
