using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatCounter : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        
        MeatCollect meatCollect = other.GetComponent<MeatCollect>();

    
        if (meatCollect != null)
        {

            meatCollect.Meat();
            gameObject.SetActive(false);

        }


    }
}
