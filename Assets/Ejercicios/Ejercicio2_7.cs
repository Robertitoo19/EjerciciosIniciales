using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    int oroFarm = 7;
    int horas = 4;
    void Start()
    {
        Debug.Log("En 4 horas ha farmeado " + oroFarm * (horas*3600) + " de oro");
    }
    void Update()
    {
        
    }
}
