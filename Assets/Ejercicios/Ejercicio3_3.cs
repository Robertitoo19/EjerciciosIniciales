using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_3 : MonoBehaviour
{
    [SerializeField] int numero;
    int dobleNum;
    int tripleNum;
    void Start()
    {
        dobleNum = numero * 2;
        tripleNum = numero * 3;
        Debug.Log("El doble de " + numero + " es: " + dobleNum + " y el triple es: " + tripleNum);
    }
    void Update()
    {
        
    }
}
