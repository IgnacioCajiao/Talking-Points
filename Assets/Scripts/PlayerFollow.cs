using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour
{
    private Transform target;

    public Vector3 offset = Vector3.zero;
    public float smoothing = 1.5f;

    public float minX, maxX, minY, maxY; // Set these values to match the background bounds

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void LateUpdate()
    {
        Vector3 targetPos = new Vector3(target.position.x, target.position.y, transform.position.z);

        // Smoothly interpolate the camera position
        Vector3 smoothedPos = Vector3.Lerp(transform.position, targetPos + offset, smoothing * Time.deltaTime);

        // Clamp the position to stay within bounds
        float clampedX = Mathf.Clamp(smoothedPos.x, minX, maxX);
        float clampedY = Mathf.Clamp(smoothedPos.y, minY, maxY);

        transform.position = new Vector3(clampedX, clampedY, transform.position.z);
    }
}