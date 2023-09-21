using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CaracterController : MonoBehaviour
{

    private new Rigidbody ridigBody;
    public float moveSpeed = 10f;
    public float rotationMoveSpeed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        ridigBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        transform.Translate(new Vector3(hor,0.0f,ver)*Time.deltaTime*moveSpeed);

        //    float rotationY = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, hor * Time.deltaTime * rotationMoveSpeed, 0));
        


    }
}
