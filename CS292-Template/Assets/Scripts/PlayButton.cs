<<<<<<< HEAD
<<<<<<< HEAD
﻿using System.Collections;
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
=======
﻿using System.Collections;
=======
﻿/*using System.Collections;
>>>>>>> PrototypeOne
using System.Collections.Generic;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public GameObject Panel;
    public void OpenPanel()
    {
        if(Panel != null){
            bool isActive = Panel.activeSelf;
            Panel.setActive(!isActive);
        }
    }
}
<<<<<<< HEAD
>>>>>>> Long
=======
*/
>>>>>>> PrototypeOne
