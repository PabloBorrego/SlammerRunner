using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FollowCamera : MonoBehaviour
{
    //Objeto del persona y las posiciones del plano
    public GameObject pj;
    private float posX;
    private float posY;


    // Start is called before the first frame update
    void Start()
    {

        posX = Mathf.Abs(pj.transform.position.x);
        posY = Mathf.Abs(pj.transform.position.y);

    }

    // Update is called once per frame
    void Update()
    {
        //El Objeto enganchado a este script actualizará su posicion

        this.gameObject.transform.position = new Vector3(
            pj.transform.position.x + posX,
            pj.transform.position.y + posY, -500);

    }
}
