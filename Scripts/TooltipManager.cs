using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TooltipManager : MonoBehaviour
{

    public static TooltipManager _instance;
    public TextMeshPro textComponent;

    private void Awake()
    {
        if( _instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible
            = true;
        gameObject.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void SetAndShowTooltip(string mensaje)
    {
        gameObject.SetActive(true);
        textComponent.text = mensaje;
    }
    public void HideTooltip()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }
}
