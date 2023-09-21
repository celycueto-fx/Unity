using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

    public float speed = 5.0f;
    public float sensitivity = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float hor = Input.GetAxisRaw("Mouse X");
        float ver = Input.GetAxisRaw("Mouse Y");
        // Rotate the camera based on the mouse movement
      
        transform.eulerAngles += new Vector3(-ver* sensitivity, hor * sensitivity, 0);
    }
}
