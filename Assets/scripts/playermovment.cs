using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovment : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    public GameObject shot;

    Vector2 movement;

    float canfire;

    public float Reloadtime = 0.2f;

    AudioSource audio;

    void Start() 
    {
        audio = GetComponent<AudioSource> ();
    }

    void Update()
    {
 
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        if (canfire > 0) canfire -=Time.deltaTime;
        
        if (Input.GetButtonDown("Fire1"))
        {
            if (canfire <= 0)
            {
              Instantiate(shot, transform.position, Quaternion.identity);
              canfire = Reloadtime;
              if (!audio.isPlaying)
              {
                audio.Play (); 
              }  
            }
            else 
            {
                audio.Stop ();
            }           
        }
    }
    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
