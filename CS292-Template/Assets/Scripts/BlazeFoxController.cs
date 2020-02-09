using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class BlazeFoxController : MonoBehaviour
{

    private float dirX;
    public int maxHealth = 5;
    private int curHealth;
    public int moveSpeed = 300;
    private float countdown;
    
    private Rigidbody2D RigidBody2d;
    // Start is called before the first frame update
    void Start()
    {
        RigidBody2d = GetComponent<Rigidbody2D>();
        curHealth = maxHealth;      
    }

    // Update is called once per frame
    void Update()
    {
       if(moveSpeed == 1000){
           countdown -= Time.deltaTime;
       }
       if(countdown < 0 ){
           moveSpeed = 500; 
       }
       dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
       RigidBody2d.velocity = new Vector2(dirX, 0f);

    }

    public void ChangeSpeed(int amount){
        
        moveSpeed = amount;
        countdown = 5;
    }

    public void changeHealth(int amount){
        curHealth -= amount;
        GUIHealthBar.instance.SetValue(curHealth);
    }

    public int getHealth(){
        return curHealth;
    }
    
}
