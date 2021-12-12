using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool juegoEnPausa = false;
    public static bool musicaPausa = false;

    public GameObject pauseMenuUI;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape)) {

            if (juegoEnPausa)
            {
                Continue();
            }
            else {
                Pause();
            }
        
        }
        
    }

    private void Continue()
    {

        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        juegoEnPausa = false;

    }

    private void Pause()
    {
        FindObjectOfType<AudioManager>().Play("MenuButton");
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        juegoEnPausa = true;
    }


    public void VolverJuego() {

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
        else {
            musicaPausa = true;
            Debug.Log("Se pausa");
            FindObjectOfType<AudioManager>().Stop("MainTheme");
        }

    }

}
