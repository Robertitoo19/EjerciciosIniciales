using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    int vidas = 5;
    float exp = 20.46f;
    char carac = 'a';
    float resultadoSuma;
    float resultadoResta;
    void Start()
    {
        Debug.Log("Mis vidas son: " + vidas + " y mi experiencia es: " + exp);

        resultadoSuma = vidas + exp;
        resultadoResta = exp - vidas;
        Debug.Log("La suma de las vidas y la xp es: " + resultadoSuma + " y la diferencia de la xp y las vidas es: " + resultadoResta);
    }
    void Update()
    {
        
    }
}
