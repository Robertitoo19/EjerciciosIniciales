using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    [SerializeField] int exp;
    int lvl;
    void Start()
    {
        lvl = 32 + (9 * exp / 5);
        Debug.Log("Eres nivel " + lvl + " segun la experiencia introducida ");
    }
    void Update()
    {
        
    }
}
