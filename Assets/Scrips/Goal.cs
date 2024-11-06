using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    public uint playerIndex;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Intenta obtener el componente Ball del objeto que ha entrado en el trigger
        Ball ball = collision.GetComponent<Ball>();
        if (ball)
        {
            // Llama al método ResetPosition de la bola
            ball.ResetPosition();
            Debug.Log("La pelota ha alcanzado el gol y ha sido reiniciada."); // Para depuración
            GameManager.instance.SetIndexPuntuacion((int)playerIndex, GameManager.instance.GetIndexPuntuacion((int)playerIndex) +1);
        }
    }
}
