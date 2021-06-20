using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ball : MonoBehaviour
{

    private new Rigidbody2D rigidbody2D;
    private float moveSpeed = 9;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }
    void Update()
    {
        rigidbody2D.velocity = rigidbody2D.velocity.normalized * moveSpeed;   
    }
    /// Абстрактний метод який викликається під час зіткнення з іншим об'єктом.
    public abstract void OnCollisionEnter2D(Collision2D other); 
    ///

}
