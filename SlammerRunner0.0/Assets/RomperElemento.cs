using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomperElemento : MonoBehaviour
{

    private int contadorObjetos = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        

        InventoryPlayer inventario = collision.GetComponent<InventoryPlayer>();

        for (int i = 0; i < inventario.estaLleno.Length; i++) {

            if (inventario.estaLleno.GetValue(i).Equals(true)) {
                contadorObjetos++;
                    }
        }

        if (contadorObjetos >= 1 && gameObject.CompareTag("BarrotesFlojos")) {
            FindObjectOfType<AudioManager>().Play("Break");
            Destroy(gameObject);
        }

        if (contadorObjetos >= 2 && gameObject.CompareTag("BarrotesNormales"))
        {
            FindObjectOfType<AudioManager>().Play("Break");
            Destroy(gameObject);
        }

        if (contadorObjetos >= 3 && gameObject.CompareTag("BarrotesReforzados"))
        {
            FindObjectOfType<AudioManager>().Play("Break");
            Destroy(gameObject);
        }
    }


}
