using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenBall : Ball
{
    Rigidbody2D rigidbody2D;
    public override void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.gameObject.tag == "greenball"|| other.collider.gameObject.tag == "freezegreen")
        {
            Destroy(other.gameObject);
        }
        if (other.collider.gameObject.tag == "redball" || other.collider.gameObject.tag == "blueball" 
            || other.collider.gameObject.tag == "freezered"|| other.collider.gameObject.tag == "freezeblue")
        {
            rigidbody2D = other.collider.gameObject.GetComponent<Rigidbody2D>();
            
            gameObject.tag = "freezegreen";
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
           

        }
    }
}
