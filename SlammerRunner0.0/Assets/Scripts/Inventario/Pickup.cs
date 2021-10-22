﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private InventoryPlayer inventario;
    public GameObject itemImage;

    // Start is called before the first frame update
    void Start()
    {
        //Se carga la instancia par poder manipular el inventario de 
        inventario = GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryPlayer>();
    }



    //Cuando colisiona con el jugador este objeto se añade al inventario
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //si hay colision
        if (collision.CompareTag("Player")) {
            //Recorre el array de objetos del jugador
            for (int i = 0; i<inventario.objetos.Length; i++) {
                //Si encuentra un hueco vacío se introduce
                if (inventario.estaLleno[i] == false) {
                    inventario.estaLleno[i] = true;
                    Instantiate(itemImage, inventario.objetos[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }



    }
}
