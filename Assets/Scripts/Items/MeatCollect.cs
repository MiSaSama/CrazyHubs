using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MeatCollect : MonoBehaviour
{
    public int numOfMeat{ get; private set; }
    public UnityEvent<MeatCollect> OnMeatCollected;
    public void Meat()

    { numOfMeat++;
      OnMeatCollected.Invoke(this);

    }
}
