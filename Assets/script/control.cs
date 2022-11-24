using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class control : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator aniPlayer;
    Rigidbody2D cuerpoPlayer;
    public float speed;
    public float fuerzaBrinco;
    int saltos;
    public TextMeshProUGUI textoScore;
    public Transform respawPoint;
    public int puntos;
    float scalenormal,scaleinvertido;

    void Start()
    {
       //obtenemos el componente regidbody de nuestro objeto
        cuerpoPlayer = this.GetComponent <Rigidbody2D>();
        saltos = 2;
        aniPlayer = GetComponent<Animator>();
       // scalenormal = transform.localScale.x;
       // scaleinvertido = transform.localScale.x * -1f;
    }

    // Update is called once per frame
    void Update()
    {
        float posX = Input.GetAxis("Horizontal")*speed;
        cuerpoPlayer.velocity = new Vector2(posX, cuerpoPlayer.velocity.y);
        if(posX == 0)
        {
            aniPlayer.SetBool("moverse", false);
        }

        if (posX > 0) //si se escala manualmente
        {
            aniPlayer.SetBool("moverse", true);
            transform.localScale = new Vector3(1, 1, 1);
            // si movieron la escala del npersonaje
            // transform.localScale = new Vector3(scaleinvertido,transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        else if (posX < 0)
        {
            aniPlayer.SetBool("moverse", true);

            transform.localScale = new Vector3(-1, 1, 1);
        // transform.localScale = new Vector3(scaleinvertido,transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }
        if (Input.GetButtonDown("Jump") && saltos > 0)
        {
            cuerpoPlayer.AddForce(new Vector2(0, fuerzaBrinco));
            saltos -= 1;
            aniPlayer.SetBool("graund", false);
            aniPlayer.SetTrigger("yump");
            //tambien se puede poner asi: saltos--
        }
        
    }
    //Este bloque se ejecuta cuando colisionamos con "algo"
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("suelo"))
        {
            saltos = 2;//Recargo mis saltos al tocar el suelo 
            aniPlayer.SetBool("graund", true);
        }
        if(collision.gameObject.CompareTag("enemy"))
        {
            transform.position = respawPoint.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
       if (collision.gameObject.CompareTag("point"))
        {
            puntos += 1;
            textoScore.text = "puntos: " + puntos.ToString();
            Destroy(collision.gameObject);
        }
    }



}
