using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardia_Movement : MonoBehaviour
{

    public float velocidadMov = 3f;
    public float velocidadRot = 5f;


    public Transform[] puntosPatrulla;
    public float tiempoEsperaInicio;
    public Rigidbody2D rb;

    private int puntoDestino;
    private float tiempoEspera;


    // Start is called before the first frame update
    void Start()
    {
        puntoDestino = 0;
        tiempoEspera = tiempoEsperaInicio;
    }

    // Update is called once per frame
    void Update()
    {
        RotarGuardia(puntoDestino);
        MoverGuardia();
    }

    public void MoverGuardia()
    {
        
        //Se mueve hacia el siguiente punto
        transform.position = Vector2.MoveTowards(
               transform.position, puntosPatrulla[puntoDestino].position, velocidadMov * Time.deltaTime);

        //Checkea si ha llegado al punto, espera el tiempo asignado, y elige un nuevo punto
        if (Vector2.Distance(transform.position, puntosPatrulla[puntoDestino].position) < 0.2f)
        {
            if (tiempoEspera <= 0)
            {
                

                puntoDestino += 1;
                tiempoEspera = tiempoEsperaInicio;

                if (puntoDestino >= puntosPatrulla.Length)
                {
                    Debug.LogError("Resetea");
                    puntoDestino = 0;
                    Debug.Log(puntoDestino);
                }
            }
            else
            {
                tiempoEspera -= Time.deltaTime;
            }

        }
    }


    public void RotarGuardia(int i)
    {

        Vector2 direccion = puntosPatrulla[i].position - transform.position;
        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        rb.rotation = angulo;

    }
}