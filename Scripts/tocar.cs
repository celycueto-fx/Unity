using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocar : MonoBehaviour
{

    public GameObject Panel;

    private void OnMouseDown()
    {
       
        if(Panel != null)
        {
            Debug.Log("Click");
            Panel.SetActive(true);
        }
        else
        {
            Panel.SetActive(false);
        }
    }
   
}
