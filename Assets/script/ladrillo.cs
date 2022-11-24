using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladrillo : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("pelotaaaa"))
        {
            GameManager.instance.addpoint();
            Destroy(gameObject);
        }


    }


}
