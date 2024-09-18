using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_2 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(ConstruirNombre("Roberto", "Garzon", "Carrilero", 20));
    }
    string ConstruirNombre(string nombre, string apellido1, string apellido2, int edad)
    {
        string saludo = ("La persona se llama " + nombre + " " + apellido1 + " " + apellido2 + " y  tiene " + edad + " años");
        return saludo;
    }
}
