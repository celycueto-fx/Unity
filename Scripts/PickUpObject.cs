using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

public class PickUpObject : MonoBehaviour
{

    public GameObject PickedObject;
    public Transform interactionZone;

    public GameObject ObjectToPickUp;

    public GameObject panel;



    
    // Update is called once per frame
    void Update()
    {


        try
        {
            if (ObjectToPickUp != null && ObjectToPickUp.GetComponent<DetectionObject>().ispickable && PickedObject == null)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {

                    PickedObject = ObjectToPickUp;
                    PickedObject.GetComponent<DetectionObject>().ispickable = false;
                    PickedObject.transform.SetParent(interactionZone);
                    PickedObject.transform.position = interactionZone.position;
                    PickedObject.GetComponent<Rigidbody>().useGravity = false;
                    PickedObject.GetComponent<Rigidbody>().isKinematic = true;
                    PickedObject.SetActive(false);
                    
                    Debug.Log("Se tomó un "+PickedObject.name);
                }

            }
            else
            {

            }

            if (Input.GetKeyDown(KeyCode.M))
            {
                Debug.Log("Se soltó "+PickedObject.name);
                
                PickedObject.transform.SetParent(null);
                PickedObject.GetComponent<DetectionObject>().ispickable = true;


                PickedObject.GetComponent<Rigidbody>().useGravity = true;
                PickedObject.GetComponent<Rigidbody>().isKinematic = false;
                PickedObject.SetActive(true);
                
                PickedObject = null;
                ObjectToPickUp = null;
                PickedObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            }

            if (PickedObject == null && ObjectToPickUp == null)
            {
                Debug.Log("");
            }

        }
        catch(Exception e)
        {

          //  Debug.Log("No hay objeto seleccionado");
        }


    }



  

}
