using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    int vidas = 5;
    int sumaVidas;
    int restaVidas;
    int cuadruVidas;
    void Start()
    {
        sumaVidas = vidas + 77;
        restaVidas = sumaVidas - 3;
        cuadruVidas = restaVidas * 4;
        Debug.Log("Las vidas mas 77 son: " + sumaVidas + ", la resta del resultado es: " + restaVidas + " y el cuadruple de este es: " + cuadruVidas);
    }
    void Update()
    {
        
    }
}
