using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMechanic : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.gameObject.tag == "redball" || other.collider.gameObject.tag == "blueball" || other.collider.gameObject.tag == "greenball")
        {
            rigidbody2D = other.collider.gameObject.GetComponent<Rigidbody2D>();
            rigidbody2D.constraints = RigidbodyConstraints2D.FreezePosition;

        }
    }

}
