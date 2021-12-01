using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guardia_Movement : MonoBehaviour
{
    public GameObject fx;
    //V Publicas
    public float velocidadMov = 3f;
    public float velocidadRot = 5f;
    public int AnguloVistazo = 80;
    public Transform[] puntosPatrulla;
    public float tiempoEsperaInicio;
    public Rigidbody2D rb;


    //V Privadas
    public Animator animator;
    private int puntoDestino;
    private float tiempoEspera;
    private bool direccionVistazo;
    private bool movimiento = false;

    void Start()
    {
        fx = transform.Find("GuardiaFX").gameObject;
        animator = fx.GetComponent<Animator>();

        puntoDestino = 0;
        tiempoEspera = tiempoEsperaInicio;
    }
    void Update()
    {
        animator.SetBool("SeMueve",movimiento);

        //Rota y se desplaza
        RotarGuardia(puntoDestino);
        MoverGuardia();
    }



    //Implementación del movimiento(Predefinido)
    public void MoverGuardia()
    {
        movimiento = true;
        //Se mueve hacia el siguiente punto
        transform.position = Vector2.MoveTowards(
               transform.position, puntosPatrulla[puntoDestino].position, velocidadMov * Time.deltaTime);

        //Checkea si ha llegado al punto, espera el tiempo asignado, y elige un nuevo punto
        if (Vector2.Distance(transform.position, puntosPatrulla[puntoDestino].position) < 0.2f)
        {

            //Si el tiempo ha llegado a cero
            if (tiempoEspera <= 0)
            {
                //Fija el nuevo punto de destino
                puntoDestino += 1;
                tiempoEspera = tiempoEsperaInicio;

                //Cambia la dirección en la que echa un vistazo para el siguiente punto
                if (direccionVistazo == true)
                {
                    direccionVistazo = false;
                }
                else
                {
                    direccionVistazo = true;
                }


                // Si has llegado al final de los puntos de destino reset de ruta
                if (puntoDestino >= puntosPatrulla.Length)
                {
                    puntoDestino = 0;
                }
            }

            //Si el tiempo no ha llegado a cero, rota sobre si mismo hasta que acaba el tiempo
            else
            {
                tiempoEspera -= Time.deltaTime;
                movimiento = false;

                //Echa un vistazo rotando hacia un lado, cambia de lado en cada punto
                if (direccionVistazo == true) {
                    transform.Rotate(0, 0, -AnguloVistazo * Time.deltaTime);
                }
                else{
                   transform.Rotate(0, 0, AnguloVistazo * Time.deltaTime);
                }
                
            }

        }
    }


    //Calculo de la tangente del angulo para rotar en la direccion al siguiente punto de destino
    public void RotarGuardia(int i)
    {
        Vector2 direccion = puntosPatrulla[i].position - transform.position;
        float angulo = Mathf.Atan2(direccion.y, direccion.x) * Mathf.Rad2Deg;
        rb.rotation = angulo;
    }
}