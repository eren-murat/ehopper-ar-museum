using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Vuforia;

public class PaintingInfoButton : MonoBehaviour
{
    public VirtualButtonBehaviour button;
    public string url;

    // Start is called before the first frame update
    void Start()
    {
        button.RegisterOnButtonPressed(OnButtonPressed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour button)
    {
        Debug.Log("Button was pressed!");
        Application.OpenURL(url);
    }

    public void OnButtonReleased(VirtualButtonBehaviour button)
    {
        Debug.Log("Button was released!");
    }
}
