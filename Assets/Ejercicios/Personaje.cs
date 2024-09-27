using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    private string nombre;
    private int vida;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Vida { get => vida; set => vida = value; }

    void Start()
    {
        
    }
    public float CalcularNivel(float EXP)
    {
        float nivel = EXP / 1000;
        return nivel;
    }
}
