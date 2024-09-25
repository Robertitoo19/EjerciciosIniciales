using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    int numero = 0;
    void Start()
    {
        while (numero<101)
        {
            Debug.Log(numero);
            numero++; 
        }
    }
}
