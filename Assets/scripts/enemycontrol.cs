using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemycontrol : MonoBehaviour
{
public GameObject explosion;
   public int speed=2;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed,0);
    }
    void OnBecameInvisible() 
    {
        Destroy(gameObject);
    }
    void Update()
    {
        if(transform.position.x >= 10)
        {
            transform.position = new Vector2(transform.position.x - 1, transform.position.y - 2);
            speed = -speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);

        }
        else if (transform.position.x <= -10)
        {
            transform.position = new Vector2(transform.position.x + 1, transform.position.y - 2);
            speed = -speed;
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);  
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            GameObject fire =(GameObject) Instantiate(explosion,other.gameObject.transform.position,Quaternion.identity);
            UnityEngine.Object.Destroy(fire, 0.5f);
        }
    }
}
