using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

public class ClickConfirm : MonoBehaviour
{

    public GameObject obj;
    public GameObject panel;
       

    private void OnMouseDown()
    {
      
        

        if (obj != null && obj.tag == "SI")
        {

            
           
            Application.OpenURL("https://www.palo-it.com/es/");

        
    }

        if (obj != null && obj.tag == "NO")
        {


            panel.SetActive(false);
        }






    }
}
