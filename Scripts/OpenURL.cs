using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenURL : MonoBehaviour
{
    public GameObject panel;
    public void openURL()
    {
        Application.OpenURL("https://github.com/celycueto-fx");

        panel.SetActive(false);
    }
    // Start is called before the first frame update
   
}
