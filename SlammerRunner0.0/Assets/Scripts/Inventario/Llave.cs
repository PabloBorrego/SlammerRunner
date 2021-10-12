using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LLave : Herramienta
{

    public LLave(bool usado, bool obtenido, string nombre)
        : base(usado = false, obtenido = false, nombre = "Llave")
    {
    }

    protected override void usarHerramienta()
    {
        throw new System.NotImplementedException();
    }
}
