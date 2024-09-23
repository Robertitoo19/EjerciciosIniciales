using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int H;   
    [SerializeField] int M;   
    [SerializeField] int S;   
    void Start()
    {
        if(H > 24 || H < 0)
        {
            Debug.Log("La hora no es valida");
        }
        else if (M < 0 || M > 60)
        {
            Debug.Log("La hora no es valida");
        }
        else if (S < 0 || S > 60)
        {
            Debug.Log("La hora no es valida");
        }
        else
        {
            Debug.Log("Son las "+H+":"+M+":"+S);
        }
    }
}
