using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchPreview : MonoBehaviour
{
    private LineRenderer lineRenderer;
    public Vector3 dragStartPoint;
    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }
    public void SetStartPoint(Vector3 worldPoint)
    {
        dragStartPoint = worldPoint;
        lineRenderer.SetPosition(0, dragStartPoint);

    }
    public void SetEndPoint(Vector3 worldPoint)
    {
        Vector3 pointoffset = worldPoint - dragStartPoint;
        Vector3 endPoint = transform.position + pointoffset;

        lineRenderer.SetPosition(1, endPoint);


    }
}
