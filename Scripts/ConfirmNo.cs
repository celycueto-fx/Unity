using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmNo : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject obj;
    public GameObject panel;


        public void Cancel()
    {



        if (obj != null && obj.tag == "NO")
        {


            panel.SetActive(false);
        }






    }

}
