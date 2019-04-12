using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public float distance = 0.01f;
   
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name=="Player")
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        //transform.position = Vector3.Lerp(transform.position, distance * Time.deltaTime);
    }
}
