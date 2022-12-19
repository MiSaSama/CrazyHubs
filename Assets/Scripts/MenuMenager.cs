using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuMenager : MonoBehaviour
{
    public GameObject Panel,MainMenu;
    

    public void SwitchScenes(string ScreenName)

    {

        SceneManager.LoadScene(ScreenName);


    }
    public void PlayGame()
    { 
       SceneManager.LoadScene("SampleScene");
        if (MainMenu == true)
        {
            
            MainMenu.SetActive(false);
             Destroy(MainMenu);
           
        }
        
       
    }

    public void OpenPanel()
    {
        if (Panel !=null)
        {
            Panel.SetActive(true);
        }
    }
    public void ClosePanel()
    {
        if (Panel==true)
        {    
        Panel.SetActive(false);
      }
        
            }

}
