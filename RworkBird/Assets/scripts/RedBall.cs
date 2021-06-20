using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedBall : Ball
{
    Rigidbody2D  rigidbody2D;   
       public override void OnCollisionEnter2D(Collision2D other)
       {     
       if (other.collider.gameObject.tag == "redball" || other.collider.gameObject.tag == "freezered")
       {
            Destroy(other.gameObject);
       }
       if ( other.collider.gameObject.tag == "blueball" || other.collider.gameObject.tag == "greenball"
            || other.collider.gameObject.tag == "freezeblue" || other.collider.gameObject.tag == "freezegreen")
       {
            rigidbody2D = other.collider.gameObject.GetComponent<Rigidbody2D>();
            
            gameObject.tag = "freezered";
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;
         
        }
     }
}
