using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public GameObject SpherePrefab;
    Vector3 Position;
    public int Counter = 100;
    int count;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (count < Counter)
            {
                Position = new Vector3(Random.Range(60, 305), transform.position.y, Random.Range(50, 270));
                Instantiate(SpherePrefab, Position, Quaternion.identity);
                count++;
            }
        }
    }
}
