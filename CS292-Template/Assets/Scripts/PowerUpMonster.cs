using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMonster : MonoBehaviour
{
    public GameObject Icon;
    void Start() {
        Icon.SetActive(false);    
    } 
    
    void OnTriggerEnter2D(Collider2D other) {

        BlazeFoxController controller = other.GetComponent<BlazeFoxController >();
        if(controller != null){
            Icon.SetActive(true);
            
            if(Icon.tag == "coffee"){
                Debug.Log("coffee");
                controller.ChangeSpeed(10);
            }
            if(Icon.tag == "monster"){
                Debug.Log("monster");
                controller.ChangeSpeed(1000);
            }
            Destroy(gameObject);
        } 
    }
}
