using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    int vidaPlayer1 = 5;
    int vidaPlayer2 = 3;
    int vidaPlayer3 = 10;
    int vidaPlayer4 = 7;
    int nuevaVida2;
    void Start()
    {
        vidaPlayer2 = vidaPlayer3;
        //nuevaVida2 = vidaPlayer2;
        vidaPlayer3 = vidaPlayer1;
        vidaPlayer1 = vidaPlayer4;
        vidaPlayer4 = vidaPlayer2;
        Debug.Log("Las nuevas vidas del player 1 son: " + vidaPlayer1 + ", las nuevas vidas del player 2 son: " + /*nuevaVida2*/vidaPlayer2+ ", las nuevas vidas del player 3 son: " + vidaPlayer3 + ", las nuevas vidas del player 4 son: " + vidaPlayer4);
    }
    void Update()
    {
        
    }
}
