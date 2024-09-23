using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_5 : MonoBehaviour
{
    void Start()
    {
        Debug.Log("El area del circulo es: " + AreaCirculo(3) + " el area del triangulo es: " + AreaTriangulo(3, 2) + " y el area del cuadrado es: " + AreaCuadrado(4));
    }
    float AreaCirculo(float radioC)
    {
        float circulo = (radioC * radioC) * 3.14f;
        return circulo;
    }
    float AreaTriangulo(float baseT, float alturaT)
    {
        float Triangulo = (baseT * alturaT) / 2;
        return Triangulo;
    }
    float AreaCuadrado(float ladoC)
    {
        float cuadrado = ladoC * ladoC;
        return cuadrado;
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
