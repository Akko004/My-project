using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    float posX;
    // Start se ejecuta  una vez
    void Start()
    {
        Debug.Log("Hola mundo");
        posX = 0;
        Debug.Log(posX);
        transform.position = new Vector2(posX, transform.position.y);
    }

    // Update se ejecuta varias veces
    void Update()
    {
        Debug.Log(posX);
        // opcion 1 para reasignar el valor de una variable
        //psX = posX + 0.001f;
        //opcion 2
        posX += 0.01f;
        // Actualizamos la posicion cada frame
        transform.position = new Vector2(posX , transform.position.y);
        if (posX > 12)
        {
            posX = -12;
        }
    }
}
