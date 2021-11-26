using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movimiento : MonoBehaviour
{
    public Animator animator;

    public float velocidadMov = 5f;
    public Rigidbody2D rb;
    public Vector2 movimientoDir;
    public float velocidadRot = 5f;


    //Espacio para los inputs del movimiento
    void Update()
    {
        if (Mathf.Abs(movimientoDir.x) > 0 || Mathf.Abs(movimientoDir.y) > 0)
        {
            animator.SetFloat("Speed", 1);
        }
        else {
            animator.SetFloat("Speed", 0);
        }
        


        //Inputs
        movimientoDir.x = Input.GetAxisRaw("Horizontal");
        movimientoDir.y = Input.GetAxisRaw("Vertical"); 
    }


    //Espacio para ejecutar el movimiento
    private void FixedUpdate()
    {
        //Movimiento con velocidad constante
        rb.MovePosition(rb.position + movimientoDir * velocidadMov * Time.fixedDeltaTime);

        //Si se está moviendo cambia lar toación hacia el frente
        if (movimientoDir != Vector2.zero) {
            Quaternion dirRotacion = Quaternion.LookRotation(Vector3.forward, movimientoDir);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, dirRotacion, velocidadRot * Time.deltaTime); 
        }
    }

}
