using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{
    [SerializeField] float radio;
    float longuitud;
    float area;
    void Start()
    {
        longuitud = 2 * 3.14f * radio;
        area = 3.14f * (radio*radio);
        Debug.Log("La longuitud de la circunferencia con radio " + radio + " es: " + longuitud + " y su area es: " + area);
    }
    void Update()
    {
        
    }
}
