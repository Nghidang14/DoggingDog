using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    SpriteRenderer sr;
    public int moveSpeed;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void FixedUpdate() 
    {
        if(Input.GetMouseButton(0))
        {
            if(Input.mousePosition.x < Screen.width / 2)
            {
                rb.velocity = Vector2.left * moveSpeed;
                sr.flipX = true;
            }
            else 
            {
                rb.velocity = Vector2.right * moveSpeed;
                sr.flipX = false;
            }
        } 
    }
}
