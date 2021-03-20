using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross : MonoBehaviour
{
    [SerializeField] private Vector3 forwardVector;
    [SerializeField] private Vector3 anythingVector;
    private Vector3 perp;

    private void Start()
    {    
        Debug.Log(perp);
    }

    private void Update()
    {
        perp = Vector3.Cross(forwardVector, anythingVector);
        Debug.DrawRay(transform.position, forwardVector * 5, Color.cyan);
        Debug.DrawRay(transform.position, anythingVector * 5, Color.black);
        Debug.DrawRay(transform.position, perp * 5,Color.red);
    }
}
