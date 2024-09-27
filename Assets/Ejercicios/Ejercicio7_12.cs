using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    private int suma;
    void Start()
    {
        int suma = SumarTodosLosNumeros(2,4);
        Debug.Log(suma);
    }
    int SumarTodosLosNumeros(int numero1, int numero2)
    {
        for (int i = numero1; i < numero2; i++)
        {
            int suma = i;
            return suma;
        }
        return suma;
    }
}
