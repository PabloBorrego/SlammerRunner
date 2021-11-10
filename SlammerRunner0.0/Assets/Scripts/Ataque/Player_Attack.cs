using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Attack : MonoBehaviour
{

    public GameObject arma;
    private bool atacando;

    // Start is called before the first frame update
    void Start()
    {
        arma.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            atacando = true;
        }
        else {
            atacando = false;
        }

        while (atacando.Equals(true)) {
            arma.SetActive(true);
        }
        
    }
}
