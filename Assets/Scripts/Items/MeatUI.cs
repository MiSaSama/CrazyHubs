using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MeatUI : MonoBehaviour
{
    private TextMeshProUGUI meatText;

    void Start()
    {
        meatText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateMeatText(MeatCollect meatCollect)

    {

        meatText.text = meatCollect.numOfMeat.ToString();
    }
}
