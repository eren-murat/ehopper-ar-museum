using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class HelloButton : MonoBehaviour
{
    public VirtualButtonBehaviour button;
    public GameObject character;

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
        // character.GetComponent<Animator>().Play("astronaut-wave");
    }

    public void OnButtonReleased(VirtualButtonBehaviour button)
    {
        Debug.Log("Button was released!");
    }
}
