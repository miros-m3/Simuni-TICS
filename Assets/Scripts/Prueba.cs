using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inciso
{
    public string respuesta;
    public bool esElegido;
}

[System.Serializable]
public class Pregunta
{
    public int indice;
    public string pregunta;
    public Inciso[] incisos = new Inciso[4];
}

[System.Serializable]
public class Prueba 
{
    public string titulo;
    public string subtitulo;
    public string instrucciones;
    public List<Pregunta> preguntas;
}
