using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    int vidas = 10;
    float exp = 78.55f;
    float producto;
    float cociente;
    float resto;
    int dobleVidas;
    float tripleExp;
    void Start()
    {
        producto = vidas * exp;
        cociente = vidas / exp;
        resto = vidas % exp;
        dobleVidas = vidas * 2;
        tripleExp = exp * 3;
        Debug.Log("El producto es: " + producto + " el cociente es: " + cociente + " el resto es: " + resto + " el doble de vidas son: " + dobleVidas + " el triple de exp es: " + tripleExp);
    }
    void Update()
    {
        
    }
}
