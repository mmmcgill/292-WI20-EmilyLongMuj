using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel()
    {
        if(Panel != null){
            bool isActive = GameScreen.activeSelf;
            GameScreen.setActive(!isActive);
        }
    }
}
