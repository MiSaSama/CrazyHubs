using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

public class KetchupUi : MonoBehaviour
{

    private TextMeshProUGUI ketchupText;
   
    void Start()
    {
        ketchupText= GetComponent<TextMeshProUGUI>();
    }

    public void UpdateKetchupText(KetchupCollect ketchupCollect) 
    
    {
        
        ketchupText.text=ketchupCollect.numOfKetchup.ToString();
      
    }
}
