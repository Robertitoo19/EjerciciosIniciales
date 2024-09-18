using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_2 : MonoBehaviour
{
    [SerializeField] int num1;
    [SerializeField] int num2;
    void Start()
    {
        if (num1 < 3 && num2 < 3)
        {
            Debug.Log("Ambos numeros son menores que 3");
        }
        else
        {
            Debug.Log("Ambos numeros NO son menores que 3");
        }
    }

}
