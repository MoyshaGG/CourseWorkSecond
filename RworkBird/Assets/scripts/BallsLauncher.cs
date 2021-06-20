using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsLauncher : MonoBehaviour
{
    private Vector3 startDragPosition;
    private Vector3 endDragPosition;

    private SpriteRenderer spriteRenderer;
    private LaunchPreview launchPreview;

    [SerializeField]
    private GameObject greenPrefab;

    [SerializeField]
    private GameObject bluePrefab;

    [SerializeField]
    private GameObject redPrefab;
    int whichball = 0;


    private void Awake()
    { 
        launchPreview = GetComponent<LaunchPreview>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.blue;
    }
    private void Update()
    {
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) + Vector3.back * -10;

        if (Input.GetMouseButtonDown(0))
        {
            StartDrag(worldPosition);
        }
        else if (Input.GetMouseButton(0))
        {
            ContinueDrag(worldPosition);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            EndDrag();
        }
    }

    private void EndDrag()
    {
        Vector3 direction = endDragPosition - startDragPosition;
        direction.Normalize();

        //  var ball = Instantiate(greenPrefab, transform.position, Quaternion.identity);
        //  ball.GetComponent<Rigidbody2D>().AddForce(-direction);





        if (whichball == 0)
        {

            var blueball = Instantiate(bluePrefab, transform.position, Quaternion.identity);
            blueball.GetComponent<Rigidbody2D>().AddForce(-direction);
            whichball++;
            spriteRenderer.color = Color.red;
        }
        
        else if (whichball == 1)
        {
            var redball = Instantiate(redPrefab, transform.position, Quaternion.identity);
            redball.GetComponent<Rigidbody2D>().AddForce(-direction);
            whichball++;
            spriteRenderer.color = Color.green;

        }
        else
        {
            var greenball = Instantiate(greenPrefab, transform.position, Quaternion.identity);
            greenball.GetComponent<Rigidbody2D>().AddForce(-direction);
            whichball=0;
            spriteRenderer.color = Color.blue;

        }

    }

    private void ContinueDrag(Vector3 worldPosition)
    {
        endDragPosition = worldPosition;
        Vector3 direction = endDragPosition - startDragPosition;
        launchPreview.SetEndPoint(transform.position - direction);
    }

    private void StartDrag(Vector3 worldPosition)
    {
        startDragPosition = worldPosition;
        launchPreview.SetStartPoint(transform.position);
    }

}