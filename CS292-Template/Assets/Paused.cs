using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paused : MonoBehaviour
{
    bool paused;
    // Start is called before the first frame update
    void Start()
    {
        paused = false;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Pause()
    {
       
            paused = !paused;
        
        if (paused)
        {
            Time.timeScale = 0;
        }
        else if (!paused)
        {
            Time.timeScale = 1;
        }
    }
}
