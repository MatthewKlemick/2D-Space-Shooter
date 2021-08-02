using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotscript : MonoBehaviour
{
    public int speed=5;

    public GameObject explosion;
    
    void Start()
    {
      GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed); 
    }

    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other) 
    {
       if (other.tag != "Player")
       {
           Destroy(other.gameObject);
           Destroy(gameObject);
           GameObject fire =(GameObject) Instantiate(explosion,other.gameObject.transform.position,Quaternion.identity);
           UnityEngine.Object.Destroy(fire, 0.5f);
       } 
    }
}
