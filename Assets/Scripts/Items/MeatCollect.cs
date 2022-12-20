using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class MeatCollect : MonoBehaviour
{
    public int numOfMeat{ get; private set; }
    public UnityEvent<MeatCollect> OnMeatCollected;
    [SerializeField] private AudioSource collection1SoundsEffect;

    public void Meat()

    {
        collection1SoundsEffect.Play();
        numOfMeat++;
        OnMeatCollected.Invoke(this);

    }
}
