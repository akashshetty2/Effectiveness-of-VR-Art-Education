using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//code used to transport the user to any exhibit they like to save them time
// navigating 
public class TeleportScript : MonoBehaviour
{
    // Start is called before the first frame update
    int y = 13;
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

       

        if (Input.GetKeyDown("u"))
        {
            //Moves the camera to the Italian exhibit 
            transform.position = new Vector3(-200, y, -100); 
        }

        if (Input.GetKeyDown("i"))
        {
            //moves the camera to the baroque exhibit
            transform.position = new Vector3(-80, y, -.2f); 
        }

        if (Input.GetKeyDown("o"))
        {
            //moves the camera to the modern art exhibit
            transform.position = new Vector3(80, y, -.2f); 
        }

        if (Input.GetKeyDown("p"))
        {
            //moves the camera to the abstract art exhibit 
            transform.position = new Vector3(200, y, -100); 
        }

        if (Input.GetKeyDown("y"))
        {
            //moves the camera to the start point 
            transform.position = new Vector3(0, y, -110); 
        }



    }
}
