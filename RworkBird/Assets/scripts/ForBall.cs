using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForBall : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.gameObject.tag == "Ball")
        {
            
          // other.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }

    }
}
