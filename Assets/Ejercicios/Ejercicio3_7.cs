using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    [SerializeField] float baseTr;
    [SerializeField] float alturaTr;
    float area;
    void Start()
    {
        area = (baseTr * alturaTr) / 2;
        Debug.Log("El area del triangulo de base " + baseTr + " y altura " + alturaTr + " es: " + area);
    }
    void Update()
    {
        
    }
}
