using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptInimigo : MonoBehaviour
{
    public float velocidade = 2;
    private Rigidbody2D rbd;
    public LayerMask mascara;
    public float distancia = 1;
    public Vector3 movement;
    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbd.velocity = new Vector2(velocidade,0);

        RaycastHit2D hit;
        hit = Physics2D.Raycast(transform.position, transform.right, distancia, mascara);
        if(hit.collider != null)
        {
            velocidade = velocidade * -1;
            rbd.velocity = new Vector2(velocidade, 0);
            transform.Rotate(new Vector2(0, 180));
        }


        //transform.position = transform.position + movement * Time.deltaTime;

        //if (transform.position.y < -7)
        //{
        //    Destroy(this.gameObject);
        //}

    }
}
