using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    int contador;
    void Start()
    {
        if(numero2 > numero1)
        {
            contador = numero1;

        }
        if (numero1 > numero2)
        {
            contador = numero2;

        }
        contador++;
    }
}
