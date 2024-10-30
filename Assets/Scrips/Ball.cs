using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 direccion;
    private Vector2 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = transform.position; // Inicializa la posici�n
        SetRandomDirection();
    }

    void SetRandomDirection()
    {
        // Establecer direcci�n inicial aleatoria
        do
        {
            direccion.x = Random.Range(-1f, 1f); // Cambiado a -1f a 1f para obtener valores flotantes
        } while (direccion.x == 0);

        direccion.y = Random.Range(-1f, 1f); // Cambiado a -1f a 1f para obtener valores flotantes
        direccion.Normalize(); // Normaliza la direcci�n para mantener la misma velocidad en todas las direcciones
    }

    private void FixedUpdate()
    {
        rb.velocity = direccion * speed;
    }

    public void ResetPosition()
    {
        transform.position = initialPosition;
        SetRandomDirection(); // Reinicia la direcci�n al restablecer la posici�n
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Cada vez que ocurra una colisi�n, reboto 
        if (collision.gameObject.GetComponent<PalaMoved>())
        {
            direccion.x *= -1; // Rebota en el eje x
            direccion.y = Random.Range(-1f, 1f); // Nueva direcci�n y
            direccion.Normalize(); // Normaliza la direcci�n
        }
        else
        {
            // Solo hay techo o suelo
            direccion.y *= -1; // Rebota en el eje y
        }
    }
}
