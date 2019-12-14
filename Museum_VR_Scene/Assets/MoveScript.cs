using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// this class is used to move camera 
public class MoveScript : MonoBehaviour
{
    float speed = 10.0f;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
       

        //storing the previous position before user input 
        Vector3 position = transform.position;

        Vector3 direction;
        //move with respect to the x-z plane 
        Vector3 change = new Vector3(Input.GetAxis("Horizontal"),
           0, Input.GetAxis("Vertical"));

        //transform the positoin of the camera depending on the user input 
        transform.position = transform.position + (change * speed *
            Time.deltaTime);

        //determines the direction where the gameobject should point to 
        direction = transform.position - position;

        //this makes the gameobject run the way it is moving for the user 
        transform.rotation = Quaternion.LookRotation(direction);




    }




}


