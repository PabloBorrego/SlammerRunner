using System.Collections;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) {
            for (int i = 0; i<inventario.objetos.Length; i++) {
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
