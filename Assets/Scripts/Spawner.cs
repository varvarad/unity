using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CubePrefab;
    Vector3 Position;
    public int Counter = 100;
    int count;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            if (count < Counter)
            {
                Position = new Vector3(Random.Range(60, 305), transform.position.y, Random.Range(50, 270));
                Instantiate(CubePrefab, Position, Quaternion.identity);
                count++;
            }
        }
        
        
    }
}
