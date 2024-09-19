using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int moveSpeed;

    private void FixedUpdate() 
    {
        transform.Rotate(0, 0, moveSpeed);
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {

        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);

            GameManager.instance.GameOver();
        }

        if(other.gameObject.tag == "Ground")
        {   
            GameManager.instance.IncrementScore();

            Destroy(gameObject);
        }
    }

}
