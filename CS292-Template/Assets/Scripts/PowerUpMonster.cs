using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMonster : MonoBehaviour
{
    public GameObject SpeedUpIcon;
    void Start() {
        SpeedUpIcon.SetActive(false);    
    } 
    
    void OnTriggerEnter2D(Collider2D other) {

        BlazeFoxController controller = other.GetComponent<BlazeFoxController >();
        if(controller != null){
            SpeedUpIcon.SetActive(true);
            controller.ChangeSpeed();
            Destroy(gameObject);
        } 
    }
}
