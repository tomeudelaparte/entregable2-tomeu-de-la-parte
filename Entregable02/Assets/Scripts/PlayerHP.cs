using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{
    // Var tipo bool que indica el estado de la partida.
    [SerializeField] private bool isGameOver;

    // Var tipo int que contiene la cantidad de vida del player.
    [SerializeField] private int playerHP = 150;
    
    // Var tipo int que contiene la cantidad de daño. 
    public int damage = 60;

    // Start is called before the first frame update
    void Start()
    {
        // Le quita vida al jugador y se actualiza la cantidad de vida de este mismo.
        playerHP -= damage;
    }

    // Update is called once per frame
    void Update()
    {

        // Comprueba si GameOver es FALSE
        if (!isGameOver)
        {

            // Comprueba si playerHP es menor o igual a 0
            if (playerHP <= 0)
            {
                Debug.Log("Te has quedado sin vida... GAME OVER");
            }

            // Comprueba si playerHP es menor a 30
            else if (playerHP < 30)
            {
                Debug.Log("¡¡¡Tienes poca vida!!!");
            }

            // Muestra la cantidad de vida restante si las comprobaciones anteriores son falsas
            else
            {
                Debug.Log($"Vas bien de vida: tienes {playerHP} puntos de vida");
            }
        }

        // Muestra GAME OVER si la comprobación anterior es falsa
        else
        {
            Debug.Log("GAME OVER");
        }
    }
}
