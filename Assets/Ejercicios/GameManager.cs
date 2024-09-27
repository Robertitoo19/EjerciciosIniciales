using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Personaje personaje1;
    bool yaEjecutado = false;
    void Start()
    {
        personaje1 = new Personaje();  
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PrepararPersonajes();
            yaEjecutado = true;
        }
    }
    void PrepararPersonajes()
    {
        personaje1.Nombre = "Juan";
        personaje1.Vida = 100;

        Debug.Log("Eres nivel "+personaje1.CalcularNivel(2000));
    }
}
