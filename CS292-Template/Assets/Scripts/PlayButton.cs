using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject GameScreen;
    public GameObject TitleScreen;
    
    public void OpenPanel()
    {
        /*if(GameScreen != null)
        {
            bool isActive = GameScreen.activeSelf;
            GameScreen.SetActive(!isActive);
        }*/
        GameScreen.SetActive(true);
        TitleScreen.SetActive(false);
    }
  
}
