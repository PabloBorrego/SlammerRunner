using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeteccionGuardias : MonoBehaviour
{
    private Player_State player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_State>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Si el 
        if (collision.CompareTag("Player"))
            {
            player.vidas -= 1;
            Debug.Log(player.vidas);
            //SceneManager.LoadScene("SampleScene");
        }
    }
}