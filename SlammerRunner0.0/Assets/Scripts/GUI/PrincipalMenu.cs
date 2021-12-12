using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrincipalMenu : MonoBehaviour
{

    public static bool musicaPausa = false;
    public GameObject principalMenuUI; 


    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("MainTheme");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Jugar()
    {
        FindObjectOfType<AudioManager>().Play("MenuButton");
        SceneManager.LoadScene("DemoLevel");
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
