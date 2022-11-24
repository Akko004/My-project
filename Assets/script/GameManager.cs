using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject panelwin;
    //public GameObject panelgameover
    public int lives;
    public static GameManager instance;
    private int score;
    public TextMeshProUGUI textopuntos;
    public GameObject mainMenu;
    // Start is called before the first frame update
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        score = 0;
        textopuntos.text = score.ToString();
     //   Time.timeScale = 0;   
       // el tiempo esta congelado
        //esto detiene la fisica y el tiempo en general 
        //pero no detiene los imputs ni los cambios en el update 
    }

    // Update is called once per frame
    void Update()
    {

        if (score>=13)
        {
            panelwin.SetActive(true);
        }
    }

    public void comenzar()
    {
        //mainMenu.SetActive(false);
      //  Time.timeScale = 1;                //vuelve a correr el tiempo
    }
    public void cargarNivel()
    {
        // SceneManager.LoadScene("ola");
      
    }
    public void addpoint() 
    {
        score++;
        textopuntos.text = score.ToString();
    }


}
