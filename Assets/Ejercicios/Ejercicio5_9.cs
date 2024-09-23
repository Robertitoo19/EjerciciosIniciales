using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    void Start()
    {
        if (tipo == 1)
        {
            Debug.Log("El enemigo hace 350 de daño y tiene 650 de vida");
        }
        else if (tipo == 2)
        {
            Debug.Log("El enemigo hace 300 de daño y tiene 550 de vida");
        }
        else if(tipo == 3)
        {
            Debug.Log("El enemigo hace 300 de daño y tiene 500 de vida");
        }
        else if (tipo==4)
        {
            Debug.Log("El enemigo hace 310 de daño y tiene 460 de vida");
        }
        else if (tipo == 5)
        {
            Debug.Log("El enemigo hace 280 de daño y tiene 490 de vida");
        }
        else if (tipo == 6)
        {
            Debug.Log("El enemigo hace 360 de daño y tiene 520 de vida");
        }
        else
        {
            Debug.Log("No has elegido un tipo valido");
        }
    }
}
