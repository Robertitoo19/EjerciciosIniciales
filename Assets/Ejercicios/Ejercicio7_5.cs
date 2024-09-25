using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        while (1<=numero1)
        {
            Debug.Log(numero1);
            numero1--;
        }
        for (int i = numero2; i >= 1; i--)
        {
            Debug.Log(i);
        }
    }
}
