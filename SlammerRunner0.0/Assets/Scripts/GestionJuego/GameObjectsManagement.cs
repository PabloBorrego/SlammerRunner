using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectsManagement : MonoBehaviour
{

    /*public GameObject[] objetos;
    public GameObject[] puntosObjetos;*/

   public List<GameObject> objetos = new List<GameObject>();
   public List<GameObject> puntosObjetos = new List<GameObject>();


    //private bool[] capacidad = new bool[3];




    // Start is called before the first frame update
    void Start()
    {
        //Mientras siga habiendo espacio se asigna un objeto
        //for (int i = 0; i < capacidad.Length; i++) {
        //    capacidad.SetValue(true, i);
        //}

        var veces = objetos.Count;

        for (int i = 0; i < veces; i++)
        {
            asignarObjeto(objetos, puntosObjetos);
        }


    }


    // Update is called once per frame
    void Update()
    {
        
    }


   /* public void colocarObjeto(List <GameObject>objeto) {

        //Mientras siga habiendo espacio se asigna un objeto
        Debug.LogError(pos);
        

        if (capacidad.GetValue(pos).Equals(true)) {

            GameObject posicion = (GameObject)puntosObjetos[pos];

            Instantiate(objeto, posicion.transform);
            capacidad.SetValue(false,pos);
        }
        

    }*/

    public void asignarObjeto(List<GameObject> objetos, List<GameObject> puntosObjetos)
    {
        int pos = Random.Range(0, objetos.Count);
        Debug.LogError("POSICION :"+puntosObjetos[0].name +puntosObjetos[0].transform.position);
        
        
        Instantiate(objetos[pos],puntosObjetos[0].transform.position, puntosObjetos[0].transform.rotation);
        

        objetos.RemoveAt(pos);
        puntosObjetos.RemoveAt(0);
    }

}
