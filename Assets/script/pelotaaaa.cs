using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class pelotaaaa : MonoBehaviour
{
   
    public TextMeshProUGUI textovidas;
    private int lives;
    public GameObject panelfinal;
    public TextMeshProUGUI textoP1;
    public Rigidbody2D rigidBody2D;
    public float speed = 300;
    private Vector2 velocity;
    private Vector2 Posinicial;
    private bool isdead;
    private int puntos;
    private GameObject panelGameOver;
    private int velX, velY;

    bool empezar;

    void Start()
    {
        lives = 3;
        textovidas.text ="lives: "+lives.ToString(); 

        Posinicial = transform.position;

        empezar = true;
    }
    public void reiniciar()
    {
        puntos = 0;
        Time.timeScale = 1;
        textoP1.text = puntos.ToString();
        panelGameOver.SetActive(false);

    }
    public void Update()
    {
        

       if(Input.GetKeyDown(KeyCode.Space) && empezar == true)
        {
            panelfinal.SetActive(false);
          // velY = Random.Range(5, -5);
           velocity.x = Random.Range(-2, 2f);
           velocity.y = 2;
           rigidBody2D.AddForce(velocity * speed);

            empezar = false;
        }
         
        
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        /*if (collision.CompareTag("muerte"))
        {
            //StartCoroutine(GameOver());
            Destroy(gameObject);  
            //velocity.x = 0;
            //speed = 0;
            rigidBody2D.velocity = Vector2.zero;
            transform.position = Posinicial;
        }*/
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("muerte"))
        {
            lives--;
           // textovidas.text = lives.ToString();
            textovidas.text = "lives: " + lives.ToString();

            if (lives<=0)
            {
            panelfinal.SetActive(true);
                StartCoroutine(GameOver());                
            }
          //  StartCoroutine(GameOver());
            //Destroy(gameObject);
            rigidBody2D.velocity = Vector2.zero;
            transform.position = Posinicial;

            empezar = true;
        }
    }  

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(2);
        lives = 3;
        //panelGameOver.SetActive(true);

      //  SceneManager.LoadScene("examen");

    }
       
}
