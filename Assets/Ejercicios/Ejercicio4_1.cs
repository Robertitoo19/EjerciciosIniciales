using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    [SerializeField] float radioC;

    [SerializeField] float baseT;
    [SerializeField] float alturaT;

    [SerializeField] float ladoC;

    void Start()
    {
        Debug.Log("El area del circulo es: " + AreaCirculo() + " el area del triangulo es: " + AreaTriangulo() + " el area del cuadrado es: " + AreaCuadrado());
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
}
