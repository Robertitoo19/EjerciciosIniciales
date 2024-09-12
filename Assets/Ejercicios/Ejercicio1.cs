using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour
{
    string nombre = "Roberto";
    void Start()
    {
        Debug.Log("¡Hola Mundo! Este es el primer videojuego de " + nombre + " y estoy aprendiendo C#");
    }
    void Update()
    {
        //Se repite porque el codigo escrito en el update se actualiza continuamente.
        Debug.Log("Ha pasado un frame");
    }
}
