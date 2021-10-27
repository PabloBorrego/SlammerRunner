using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEscondido : MonoBehaviour
{

    private Player_State player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player_State>();    
    }

    //Si el jugador entre en una zona que se pueda esconder
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            player.escondido = true;
            Debug.LogError(player.escondido);
        }
    }

    //Si el jugador sale de uan zona que se pueda esconder
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.escondido = false;
            Debug.LogError(player.escondido);
        }
    }


}
