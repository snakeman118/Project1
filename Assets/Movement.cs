using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//script  calling for movement
public class Movement : MonoBehaviour
{
    //set speed
    public float speed = 1.5f;
    public bool set = false, done = false;
    //call for input of each key
    void Update()
    {
        //while shift is pressed move faster
        if (Input.GetKey(KeyCode.LeftShift))
        {
            //set speed to double 
            speed = 3.0f;
        }
        else
        {
            speed = 1.5f;
        }
        //when space is pressed reset
        if (Input.GetKey(KeyCode.Space))
        {
            //set player position to origional position
            transform.position = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.P))
        {
            set = !set;
        }
        if (set == true)
        {
            speed = 0f;
        }
        if (Input.GetKey(KeyCode.Q))
        {
            done = true;
        }
        if (done == true)
        {
            speed = 0f;
        }
            //left arrow moves to the left
            if (Input.GetKey(KeyCode.LeftArrow))
        {
            //set Z axis to ship looking left
            transform.eulerAngles = new Vector3(0, 0, 90);
            //set to move to the left at the set speed
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        //right arrow moves to the right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //set Z axis to ship looking right
            transform.eulerAngles = new Vector3(0, 0, 270);
            //set to move to the right at the set speed
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        //up arrow moves up
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //set Z axis to ship looking up
            transform.eulerAngles = new Vector3(0, 0, 0);
            //set to move to the up at the set speed
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        //down arrow moves down
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //set Z axis to ship looking down
            transform.eulerAngles = new Vector3(0, 0, 180);
            //set to move to the down at the set speed
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }
}
