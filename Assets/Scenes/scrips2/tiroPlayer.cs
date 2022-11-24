using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroPlayer : MonoBehaviour
{
    Transform posMira;
    public GameObject bala;
    AudioSource sonidobala;

    void Start()
    {
        posMira = GameObject.Find("Mira").GetComponent<Transform>();
        sonidobala=GetComponent<AudioSource>(); // obtengo el componente de audio
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bala, posMira.transform.position, Quaternion.identity);
            sonidobala.Play(); // reproducir en el momento que da click
        }
    }
}
