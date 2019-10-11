using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    float speed = 7.0f; 

    // Start is called before the first frame update
    void Start()
    {
       
    }

// Update is called once per frame
void Update()
{
        //move with respect to the x-z plane 
        Vector3 change = new Vector3(Input.GetAxis("Horizontal"),
           0, Input.GetAxis("Vertical"));

        //transform the positoin of the camera depending on the user input 
        transform.position = transform.position + (change * speed *
            Time.deltaTime);
}
    
       

}
