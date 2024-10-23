using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PalaMoved : MonoBehaviour
{
    public float speed;
    public string ejeH, ejeV;
    private Rigidbody2D rb;
    private float x, y;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movimiento pala 1 
       // if (gameObject.CompareTag("PalaIzq"))
        {
            x = Input.GetAxis (ejeH);
            y = Input.GetAxis(ejeV);
        }
        // Movimiento pala 2 
       //// else if (gameObject.CompareTag("PalaDer"))
       // {
       //     x = Input.GetAxis("Horizontal2");
       //     y = Input.GetAxis("Vertical2");
       // }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x, y) * speed;
    }
}
