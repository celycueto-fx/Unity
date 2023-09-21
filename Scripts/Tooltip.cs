using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public GameObject obj;
    public GameObject panel;
   // public string message="hOLA";

     private void OnTriggerEnter(Collider other)

    { 

    if(obj.GetComponent<DetectionObject>().ispickable ){

        if (other.tag == "objeto")
        {
            panel.SetActive(true);
        }
        
    }
}

  
 
}
