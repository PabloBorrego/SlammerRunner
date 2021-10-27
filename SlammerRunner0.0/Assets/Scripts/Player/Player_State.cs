using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_State : MonoBehaviour
{
    //Atributos publicos
    public int vidas;
    public bool escondido;

    //Atributos privados
    private double scoreActual;



    // Start is called before the first frame update
    void Start()
    {
        vidas = 3;
        scoreActual = 0;
        escondido = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas == 0) {
            Debug.LogError("No quedan vidas se vuelve al menu de inicio");
        
        }

    }
}
