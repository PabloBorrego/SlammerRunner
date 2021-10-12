using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour
{

    public Herramienta[]listaObjetos ;

    // Start is called before the first frame update
    void Start()
    {
        listaObjetos = new Herramienta[3];


    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void addHerramienta(Herramienta tool) {
        foreach (Herramienta i in this.listaObjetos)
        {
            if (i == null){ 
            }
        }
    }
}
