using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Animation : MonoBehaviour
{

    float speed = 50f;
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verificalInput = Input.GetAxis("Vertical");

        Vector3 moventDIRECTION = new Vector3(horizontalInput, 0, verificalInput);

        transform.position=transform.position + moventDIRECTION*speed*Time.deltaTime ;



    }
}
