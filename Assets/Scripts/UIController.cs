using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI paintingInfo;
    [SerializeField] private Button button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowUI(string paintingText)
    {
        paintingInfo.text = paintingText;
        button.enabled = true;
    }

    public void HideUI()
    {
        paintingInfo.text = "";
        button.enabled = false;
    }
}
