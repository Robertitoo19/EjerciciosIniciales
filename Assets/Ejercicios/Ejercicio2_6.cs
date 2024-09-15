using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    int puntuacion1 = 15;
    int puntuacion2 = 5;
    int puntuacion3 = 8;
    int mediaPuntuaciones;
    void Start()
    {
        mediaPuntuaciones = (puntuacion1 + puntuacion2 + puntuacion3) / 3;
        Debug.Log("La puntuacion 1 es: " + puntuacion1 + ", la puntuacion 2 es: " + puntuacion2 + ", la puntuacion 3 es: " + puntuacion3 + " y la media de las puntuaciones es: " + mediaPuntuaciones);
    }
    void Update()
    {
        
    }
}
