using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_6 : MonoBehaviour
{
    [SerializeField] int nivel;
    void Start()
    {
        if (nivel % 10 == 0)
        {
            Debug.Log("Has aprendido un nuevo ataque");
        }
    }
}
