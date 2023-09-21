using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Video;

public class Click : MonoBehaviour
{

    public GameObject obj;
    public GameObject panel;
    // Start is called before the first frame update
    
   

    private void OnMouseDown()
    {
      

        if (obj != null && obj.tag == "click")
        {

            panel.SetActive(true);
           
           // Application.OpenURL("https://www.palo-it.com/es/");
        }




    }
}
