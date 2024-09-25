using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_7 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        while (numero1!=numero2)
        {
            if (numero1 < numero2)
            {
                Debug.Log(numero1);
                numero2--;
            }
            else if(numero2 < numero1)
            {
                Debug.Log(numero2);
                numero1--;
            }
            else
            {
                Debug.Log("Los numeros son iguales");
            }
        }
    }
}
