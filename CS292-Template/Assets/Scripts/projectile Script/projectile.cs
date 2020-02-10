using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectile : MonoBehaviour
{   
    private float minSpeed = 30;
    private float maxSpeed = 100;
    public GameObject slowdownIcon;
    private float slowDuration;

    float speed;
    float TempSpeed;

    void Start(){
        speed = 50;
        TempSpeed = speed;
    }
    void OnTriggerEnter2D(Collider2D other){
        BlazeFoxController controller = other.GetComponent<BlazeFoxController >();
        if(controller != null){
            controller.changeHealth(1);
        } 
        projectile noTouch = other.GetComponent<projectile >();
        if(noTouch != null){
            return; 
        }
        HighScore.instance.changeScore(1);
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()//TODO: redo code plz, this looks so ugly
    {
        transform.Translate(Vector2.down*speed*Time.deltaTime);
        
        if(slowDuration > 0 && slowdownIcon.activeSelf){
            slowDuration -= Time.deltaTime;
        }

        if(slowDuration <= 0 && slowdownIcon.activeSelf){
            speed = speed/5;
            slowDuration = 5;
        } 
        if(!slowdownIcon.activeSelf){
            speed = TempSpeed;
        }
    }
    
    void slowDown(){
        if(slowDuration < 0 && slowdownIcon.activeSelf){
            speed = speed/5;
            slowDuration = 5;
        }
    }
}
