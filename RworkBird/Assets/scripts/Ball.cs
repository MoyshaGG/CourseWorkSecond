using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ball : MonoBehaviour
{
    protected Vector3 startDragPosition;
    protected Vector3 endDragPosition;


    //
    protected SpriteRenderer spriteRenderer;
    protected LaunchPreview launchPreview;

    [SerializeField]
    protected GameObject greenPrefab;

    [SerializeField]
    protected GameObject bluePrefab;

    [SerializeField]
    protected GameObject redPrefab;
    protected int whichball = 0;
    //


    private new Rigidbody2D rigidbody2D;
    private float moveSpeed = 9;


    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        launchPreview = GetComponent<LaunchPreview>();
        spriteRenderer = GetComponent<SpriteRenderer>();


    }

    void Update()
    {
        rigidbody2D.velocity = rigidbody2D.velocity.normalized * moveSpeed;
    }
    protected virtual void EndDrag()
    {
        Vector3 direction = endDragPosition - startDragPosition;
        direction.Normalize();
    }
    /// Абстрактний метод який викликається під час зіткнення з іншим об'єктом.
    public abstract void OnCollisionEnter2D(Collision2D other);
    ///

}
