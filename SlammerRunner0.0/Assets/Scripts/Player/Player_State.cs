using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_State : MonoBehaviour
{
    private GameTimeManagement gM;
    public int vidas { get; set; }
    private double scoreActual { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        gM = GameObject.FindGameObjectWithTag("GameManagement").GetComponent<GameTimeManagement>();
        vidas = 3;
        scoreActual = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas == 0) {
        Debug.LogError("Entra");

            //Perform de la pantalla de perdida
            gM.StartPause();
            Debug.LogError("Salw");
        }

    }
}
