using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameTimeManagement : MonoBehaviour
{
    public float tiempoPausa = 5f;

    //Iniciar la pausa
    public void StartPause()
    {
        StartCoroutine(freezeTiempoCaptura(this.tiempoPausa));
    }

    //Metodo para para el tiempo de ejecucion 5 segundos
    public IEnumerator freezeTiempoCaptura(float pauseTIme)
    {
        //Se para el tiempo 
        Time.timeScale = 0f;

        float pauseEndTime = Time.realtimeSinceStartup + tiempoPausa;

        //Mientras no haya pasado el tiempo necesario
        while (Time.realtimeSinceStartup < pauseEndTime)
        {
            //espera al siguiente frame
            yield return 0;
        }

        //Se reactiva el tiempo
        Time.timeScale = 1f;

        recargaEscena();
    }

    //recargo de la escena
    private void recargaEscena()
    {
        SceneManager.LoadScene("DemoLevel");
    }
}
