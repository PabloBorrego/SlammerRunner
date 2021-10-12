using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Herramienta
{
    public bool usado;
    public bool obtenido;
    public string nombre;

    protected Herramienta(bool usado, bool obtenido, string nombre)
    {
        this.usado = usado;
        this.obtenido = obtenido;
        this.nombre = nombre;
    }
    protected Herramienta()
    {
    }

    protected abstract void usarHerramienta();
    
}
