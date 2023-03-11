using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFlying : MonoBehaviour
{
    public bool isDead;
    public float velocity =1f;
    public GameManager manager;
    public GameObject DeathScreen;
    private Rigidbody2D rgbody2D;
    void Start()
    {
        rgbody2D=GetComponent<Rigidbody2D>();
        Time.timeScale=1
        ;
    }

    void Update()
    {
        //Control the click
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1))
        {
            //Make fly the fucking bird
            rgbody2D.velocity=Vector2.up *velocity;

        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.name== "Score_Area")
        {
            manager.UpdateScore();
            
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag=="DeathArea")
        {
            Time.timeScale=0;
            isDead=true;
            DeathScreen.SetActive(true);
            
        }
    }
}
