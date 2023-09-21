using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationAvatar : MonoBehaviour
{
    float speed = 50f;
    float velocidadMovimiento = 5.0f;
    float velocidadRotacion = 200.0f;
    float x, y;
    Animator anim;
    private new Rigidbody ridigBody;
    // Start is called before the first frame update
    void Start()
    {
        anim =GetComponentInParent<Animator>();
        ridigBody = GetComponentInParent<Rigidbody>();
    }


    // Update is called once per frame


    // Update is called once per frame
    void Update()
    {
      
        float horizontalInput = Input.GetAxis("Horizontal");
        float verificalInput = Input.GetAxis("Vertical");

        Vector3 moventDIRECTION = new Vector3(horizontalInput, 0, verificalInput);

        transform.position = transform.position + moventDIRECTION * speed * Time.deltaTime;
        Quaternion.Euler(horizontalInput, 0, 0);


        anim.SetFloat("X", horizontalInput);
        anim.SetFloat("Y", verificalInput);
      /*  Vector3 moventDIRECTION = new Vector3(horizontalInput, 0, verificalInput);

        transform.position = transform.position + moventDIRECTION * speed * Time.deltaTime;

        */

    }
}
