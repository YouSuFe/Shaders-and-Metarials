using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    public Vector3 rotationVector; // the vector to rotate around
    private Vector3 rotationCenter;
    public GameObject rotationObject;

    private void Start()
    {
        rotationCenter = rotationObject.gameObject.transform.position;
    }

    private void Update()
    {
        transform.RotateAround(rotationCenter, rotationVector, 1f); // rotate the object around the center point
    }
}
