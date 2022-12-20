using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    private bool IsOn = true;
    public Button button;
    public AudioSource audioSource;
    
    public void ButtonClicked()
    {  if (IsOn)
    {
      
    IsOn=false;
    audioSource.mute=true;
    }

    else
{
    IsOn =true;
    audioSource.mute = false ;
}

         }
}
