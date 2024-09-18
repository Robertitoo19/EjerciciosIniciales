using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
        if (num2 != 0)
        {
            Debug.Log(num1 + " dividido entre " + num2 + " es: " + num1 / num2);
        }
        else
        {
            Debug.Log("El divisor es 0");
        }
    }
}
