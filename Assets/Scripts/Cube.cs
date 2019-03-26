using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float distance = 0.01f;
    Vector3 TargetPosition;

    void Start()
        
    {
        Destroy(gameObject, 5f);
    }

    
    void Update()
    {
    transform.position = Vector3.Lerp(transform.position, TargetPosition, distance * Time.deltaTime);
    }
}
