using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class AxisExample : MonoBehaviour
{

    public float hRange;
    public float vRange;
    
    public TextMeshPro  vTextOutput;
    public TextMeshPro  hTextOutput;
    void Update () 
    {
        float h = Input.GetAxis("Horizontal");
        //float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float vPos = v * vRange;
        
        transform.position = new Vector3(xPos, 2f, vPos);
        //textOutput.text = "Value Returned: " + h.ToString("F2");  
        vTextOutput.text = $"H Value Returned: + {h:F2}";
        hTextOutput.text = $"V Value Returned: + {v:F2}";
    }
}
