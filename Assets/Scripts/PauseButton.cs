using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    public GameObject PauseMenuPanel;

    public void ShowPauseMenu()
    {
        PauseMenuPanel.SetActive(true);


    }
}
