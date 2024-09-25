using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero1;
    [SerializeField] int numero2;
    void Start()
    {
        while (-numero1<=numero1)
        {
            Debug.Log(numero1);
            numero1--;
        }
        for (int i = numero2; i >= -numero2; i--)
        {
            Debug.Log (i);
        }
    }
}
