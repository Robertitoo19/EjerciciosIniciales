using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        for (int i = numero1; i < numero2; i++)
        {
            Debug.Log(i%2==0);   
        }
    }
}
