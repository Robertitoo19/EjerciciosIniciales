using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_9 : MonoBehaviour
{
    [SerializeField] int numero;
    void Start()
    {
        for (int i = 0; i < numero; i++) 
        {
            Debug.Log(i%3==0);
        }
    }
}
