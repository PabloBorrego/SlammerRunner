using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movimiento : MonoBehaviour
{

    public float velocidadMov = 5f;
    public Rigidbody2D rb;
    public Vector2 movimientoDir;


    //Espacio para los inputs del movimiento
    void Update()
    {
        //Inputs
        movimientoDir.x = Input.GetAxisRaw("Horizontal");
        movimientoDir.y = Input.GetAxisRaw("Vertical"); 
    }


    //Espacio para ejecutar el movimiento
    private void FixedUpdate()
    {
           //Movimiento con velocidad constante
           rb.MovePosition(rb.position + movimientoDir * velocidadMov * Time.fixedDeltaTime);
    }

}
