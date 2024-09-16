using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    int vida = 120;
    float primerVen;
    float segunVen;
    float tercerVen;
    float cuartoVen;
    float quintoVen;
    void Start()
    {
        primerVen = vida - (vida * 0.03f);
        segunVen = vida - (vida * 0.06f);
        tercerVen = vida - (vida * 0.09f);
        cuartoVen = vida - (vida * 0.12f);
        quintoVen = vida - (vida * 0.15f);
        Debug.Log("La vida tras el primer veneno será: " + primerVen + " tras el segundo: " + segunVen + " tras el tercero: " + tercerVen + " tras el cuarto: " + cuartoVen+" tras el quinto: " + quintoVen);
        
    }
    void Update()
    {
        
    }
}
