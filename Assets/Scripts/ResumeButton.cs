using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ResumeButton : MonoBehaviour
{
    public GameObject menuPanel;

    public void ResumeGame()
    {   
      //  if( menuPanel != null)
      //  { }
        menuPanel.SetActive(false);

    }


}
