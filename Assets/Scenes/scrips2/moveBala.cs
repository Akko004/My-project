using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBala : MonoBehaviour
{
    float posXbala;
    float balaVel;
    void Start()
    {
        Destroy(gameObject, 3f);
        balaVel = Random.Range(0.01f, 0.05f); // velocidad inicial de la bala
        posXbala = transform.position.x; //pos inicial de la bala
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(posXbala, transform.position.y);
        posXbala += balaVel; //Le sumamamos la velocidad a la pos
    }
}
