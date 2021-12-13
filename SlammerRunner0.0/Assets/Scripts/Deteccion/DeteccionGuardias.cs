using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeteccionGuardias : MonoBehaviour
{
    private GameTimeManagement gM;
    private Player_State player;
    public GameObject menuDerrota;

    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.FindGameObjectWithTag("GameManagement").GetComponent<GameTimeManagement>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_State>();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si la colision detectada lleva la etiqeta de jugador y no está escondido
        if (collision.CompareTag("Player") && player.escondido.Equals(false))
            {

            FindObjectOfType<AudioManager>().Play("GameOver");
            menuDerrota.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void Continue()
    {

        FindObjectOfType<AudioManager>().Play("MenuButton");
        SceneManager.LoadScene("DemoLevel");
    }

    public void Menu()
    {
        FindObjectOfType<AudioManager>().Play("MenuButton");
        SceneManager.LoadScene("MenuPrincipal");

    }

}