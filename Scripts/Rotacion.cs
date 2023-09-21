using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{

    [SerializeField, Tooltip("Angular velocity in degrees per second")]
    Vector3 m_Velocity;

    int count =1;
    float z= 0;
    void Update()


    {
        transform.Rotate(new Vector3(0,0,0) * Time.deltaTime); ;

        if (Input.GetKeyDown(KeyCode.O))
        { 
        count++;
        }

     
        if ((count % 2) == 0)
        {

                transform.Rotate(m_Velocity * Time.deltaTime);

        }
        else
        {
            transform.Rotate(new Vector3(0, 0, 0));
        }
       
     


    
       

    }
}
