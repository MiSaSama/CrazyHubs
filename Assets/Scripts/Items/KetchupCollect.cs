using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KetchupCollect : MonoBehaviour
{
    public int numOfKetchup { get; private set; }
    public UnityEvent<KetchupCollect> OnKetchupCollected;

    public void Ketchup() 
    {
         numOfKetchup++;
         OnKetchupCollected.Invoke(this);
        
                 
       
    }


    
}
