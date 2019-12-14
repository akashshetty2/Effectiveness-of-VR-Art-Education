using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontal = 2.0F;
    public float vertical = 2.0F; 


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalPos = horizontal * Input.GetAxis("Mouse X");
        float verticalPos = vertical * Input.GetAxis("Mouse Y");
        transform.Rotate(verticalPos, horizontalPos, 0);

    }
}
