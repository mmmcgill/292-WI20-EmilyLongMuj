using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIHealthBar : MonoBehaviour
{
    public GameObject FullHealth;
    public GameObject OneHit;
    public GameObject TwoHit;
    public GameObject ThreeHit;
    public GameObject FourHit;
    public GameObject FiveHit;

    public static GUIHealthBar instance {get; private set;}
    // Start is called before the first frame update

    GameObject[] HealthBar;
    void Awake(){
        instance = this;
    }

    void Start()
    {
        HealthBar = new GameObject[] {FullHealth, OneHit, TwoHit, ThreeHit, FourHit, FiveHit};
        for(int i = 1; i < 6; i++){
            HealthBar[i].SetActive(false);
        }
    }

    // Update is called once per frame
    public void SetValue(int value){
        int health = 5 - value;
        for(int i = 1; i < 6 ;i++){
            if(i == health){
                HealthBar[i].SetActive(true);
            }
            else HealthBar[i].SetActive(false);
        }
    }
}
