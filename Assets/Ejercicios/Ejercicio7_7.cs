using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    public int contador;
    void Start()
    {
        
        if (numero1<numero2)
        {
            contador = numero1;
            while (numero1<numero2)
            {
                Debug.Log(numero1);
                contador++;
            }
        }
        if (numero2 < numero1)
        {
            contador = numero2;
            while (numero2 < numero1)
            {
                Debug.Log(numero2);
                contador++;
            }
        }
        contador++;
    }
}
