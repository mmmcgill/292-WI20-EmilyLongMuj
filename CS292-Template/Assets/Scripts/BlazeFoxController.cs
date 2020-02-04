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
    public int moveSpeed = 100;
    
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
       
       dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
       RigidBody2d.velocity = new Vector2(dirX, 0f);
    }

    public void ChangeSpeed(){
        
        moveSpeed = 1000;
    }

    void changeHealth(int amount){
        curHealth -= amount;
    }
}
