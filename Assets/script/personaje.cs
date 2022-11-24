using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    Transform posMira;
    public GameObject bala;

    void Start()
    {
        posMira = GameObject.Find("Mira").GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bala, posMira.transform.position,Quaternion.identity);
        }
    }
}
