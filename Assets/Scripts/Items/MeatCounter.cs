using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeatCounter : MonoBehaviour
{
    public void Update()
    {
        transform.Rotate( 0, 20 * Time.deltaTime, 0);
    }
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
