using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    [SerializeField] float velocidadKmH;
    float metrosSeg;
    void Start()
    {
        metrosSeg = (velocidadKmH * 1000) / 3600;
        Debug.Log(velocidadKmH + " Km/H son " + metrosSeg + " M/S");
    }
    void Update()
    {
        
    }
}
