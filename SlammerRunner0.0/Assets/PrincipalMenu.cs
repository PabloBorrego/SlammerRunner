using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincipalMenu : MonoBehaviour
{

    public static bool musicaPausa = false;

    public GameObject pauseMenuUI;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Pause()
    {
        FindObjectOfType<AudioManager>().Play("MenuButton");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        juegoEnPausa = true;
    }


    public void VolverJuego()
    {

        FindObjectOfType<AudioManager>().Play("MenuButton");
        Debug.Log("CONTINUA");
        Continue();

    }



    public void Menu()
    {
        FindObjectOfType<AudioManager>().Play("MenuButton");
        SceneManager.LoadScene("Menu");

    }


    public void Salir()
    {
        FindObjectOfType<AudioManager>().Play("MenuButton");
        Application.Quit();
    }

    public void Silenciar()
    {
        FindObjectOfType<AudioManager>().Play("MenuButton");

        if (musicaPausa)
        {
            musicaPausa = false;
            Debug.Log("Se inicia");
            FindObjectOfType<AudioManager>().Play("MainTheme");
        }
        else
        {
            musicaPausa = true;
            Debug.Log("Se pausa");
            FindObjectOfType<AudioManager>().Stop("MainTheme");
        }

    }



}
