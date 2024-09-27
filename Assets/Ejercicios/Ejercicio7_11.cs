using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
        for (int i = numero; i <= numero; i++)
        {
            for (int j = 0; j <= 10; j++)
            {
                Debug.Log(i + " por " + j + " =" + " " + i * j);
            }
        }
    }
}
