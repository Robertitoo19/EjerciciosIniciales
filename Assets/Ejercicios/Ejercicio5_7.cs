using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velocidad1;  
    [SerializeField] int velocidad2;  
    [SerializeField] int velocidad3;  
    void Start()
    {
        if (velocidad2 < velocidad1 && velocidad3 < velocidad1)
        {
            Debug.Log("El jugador 1 comenzara");
        }
        else if (velocidad1 < velocidad2 && velocidad3 < velocidad2)
        {
            Debug.Log("El jugador 2 comenzara");
        }
        else
        {
            Debug.Log("El jugador 3 comenzara");
        }
    }
}
