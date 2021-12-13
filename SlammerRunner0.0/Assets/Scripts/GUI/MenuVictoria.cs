using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuVictoria : MonoBehaviour
{


    public GameObject menuVictoria;

    // Start is called before the first frame update
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        menuVictoria.SetActive(true);
        Time.timeScale = 0f;
        FindObjectOfType<AudioManager>().Play("Win");
    }


}
