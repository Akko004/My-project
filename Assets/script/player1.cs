using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    Vector3 mousePos;
    public float minY, maxY;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos);
        float posYlimited = Mathf.Clamp(mousePos.y, minY, maxY);
        transform.position = new Vector3(transform.position.x,posYlimited,0) ;
        
    }
}
