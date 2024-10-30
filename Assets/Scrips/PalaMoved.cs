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
      
        {
            x = Input.GetAxis(ejeH);
            //y = Input.GetAxis(ejeV);

            y = Input.GetAxis(ejeV);
            transform.Translate(new Vector2 (0, y) * speed * Time.deltaTime);


        }
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(x, y) * speed;
    }
}
