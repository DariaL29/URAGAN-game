using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControl : MonoBehaviour
{
    
    public Rigidbody rbody;
    public float jumpForce;
    public float xPosition = 0;
    public static int numberSun = 0;
    public Text score;
   


     void Start()
    {

      
    }
    void FixedUpdate()
    {
        rbody.transform.position = new Vector3(xPosition, rbody.transform.position.y, rbody.transform.position.z);

        if (Input.GetKey(KeyCode.Space) && Mathf.Abs(rbody.velocity.y) < 0.3)
        {
            Debug.Log("Jumping");
            rbody.velocity = new Vector3(rbody.velocity.x, 5, rbody.velocity.z);
        }
        else
        {
            Debug.Log("Not jumping" + rbody.velocity.y);
        }

        rbody.velocity = new Vector3(rbody.velocity.x, rbody.velocity.y, 3);
    }
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (xPosition < 1)
            {
                xPosition++;
            }
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (xPosition > -1)
            {
                xPosition--;
            }
            
           
        }
        score.text = "Score:" + numberSun;


        if (Input.anyKeyDown && Time.timeScale == 0)
        {

            numberSun = 0;

        }





    }




}

