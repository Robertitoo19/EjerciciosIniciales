using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    void Start()
    {
        Debug.Log(Conversor(120));
    }
    string Conversor(int kilometroHora)
    {
        string MetroSeg = (kilometroHora + " km/h son " + (kilometroHora * 1000) / 3600 + " m/s");
        return MetroSeg;
    }
}
