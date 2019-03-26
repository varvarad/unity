using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Vector3 MyVector = new Vector3(3.2f, 4.4f, 5.1f);
    public int firstNum = 5;
    public int secondNum = 2;

    int Summ;
    public GameObject Cube;
    

    void Start()
    {
       
    }

    int TEST(int first, int second)
    {
        Summ = first + second;
        Debug.Log("сумма" + Summ);
        return Summ;
    }

    void Update()
    {
        
    }
}
