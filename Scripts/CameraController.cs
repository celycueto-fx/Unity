using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speedH;
    public float speedV;

    float yaw;
    float pitch;
    private new Transform camera;
    public float rayDistance;
    // Start is called before the first frame update
    void Start()
    {
        //camera = transform.Find("Camera");
    }

    // Update is called once per frame
    void Update()
    {

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV*Input.GetAxis("Mouse Y");

        transform.eulerAngles=new Vector3 (pitch, yaw, 0.0f);

        if(Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None; 



        }
        /*Debug.DrawRay(camera.position, camera.forward,Color.red);

        
            RaycastHit hit;
            if (Physics.Raycast(camera.position, camera.forward, out hit, rayDistance))
            {
                Debug.Log(hit.transform.name);
            }
        */

    }

    void OnGUI()
    {
        //Press this button to lock the Cursor
        if (GUI.Button(new Rect(0, 0, 100, 50), "Lock Cursor"))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        //Press this button to confine the Cursor within the screen
        if (GUI.Button(new Rect(125, 0, 100, 50), "Confine Cursor"))
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
