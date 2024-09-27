using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_13 : MonoBehaviour
{
    void Start()
    {
        string mensaje = Primo(25);
        Debug.Log(mensaje);
    }
    string Primo(int numero)
    {

        if(numero/1==numero||numero/numero==1)
        {
            string mensaje = numero + " es primo";
            return mensaje;
        }
        else
        {
            string mensaje = numero + " no es primo";
            return mensaje;
        }
    }
}
