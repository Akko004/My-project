using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : MonoBehaviour
{
    Vector3 centro;
    Rigidbody2D rbPelota;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        centro = Vector3.zero; //esto es el vector3 (0,0,0)
        transform.position = centro;
        rbPelota = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //iniciamos el juego
            rbPelota.velocity = new Vector2(1, 1) * speed;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("porteriaPlayer2"))
        {
            transform.position = centro;
            rbPelota.velocity = Vector2.zero;
            //Aqui sumariamos puntos al Player 2
        }
        else if (collision.gameObject.CompareTag("porteriaPlayer1"))
        {
            transform.position = centro;
            rbPelota.velocity = Vector2.zero;
        }
    }
}

