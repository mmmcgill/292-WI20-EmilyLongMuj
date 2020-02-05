using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterIcon : MonoBehaviour
{
    public GameObject SpeedUpIcon;
    private float countdown;
    // Start is called before the first frame update
    void Start()
    {
        if(SpeedUpIcon.activeSelf){
            countdown = 5;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown > 0){
            countdown -= Time.deltaTime;
        }
        else{
            SpeedUpIcon.SetActive(false);
        }
        //TODO: Re-check when drink monster again
    }
}
