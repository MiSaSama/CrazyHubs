using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KetchupCollect : MonoBehaviour
{
    public int numOfKetchup { get; private set; }
    public UnityEvent<KetchupCollect> OnKetchupCollected;
    [SerializeField] private AudioSource collection2SoundsEffect;

    
    public void Ketchup()
    {
        collection2SoundsEffect.Play();
         numOfKetchup++;
         OnKetchupCollected.Invoke(this);
        
                 
       
    }


    
}
