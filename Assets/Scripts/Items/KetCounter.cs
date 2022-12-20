using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KetCounter : MonoBehaviour
{

   
         
    private void OnTriggerEnter(Collider other)
    {

        KetchupCollect ketchupCollect = other.GetComponent<KetchupCollect>();
        

        if (ketchupCollect != null)
        {
            ketchupCollect.Ketchup();
            gameObject.SetActive(false);

        }
       

    }
}
