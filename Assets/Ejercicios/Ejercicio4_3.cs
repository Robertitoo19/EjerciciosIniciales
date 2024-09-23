using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Convertir(4, "dolares"));
    }
    string Convertir(float cantidad, string moneda)
    {
        string resultado = "";
        if (moneda == "Dolares" || moneda == "dolares")
        {
            resultado = (cantidad + moneda + " " + " son " + cantidad * 0.9 + " euros");
        }
        if (moneda == "Euros" || moneda == "euros")
        {
            resultado = (cantidad + " " + moneda + " son " + cantidad * 1.11 + " dolares");
        }
        return resultado;
    }
}
