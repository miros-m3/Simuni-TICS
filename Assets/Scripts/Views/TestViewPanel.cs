using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestViewPanel : View
{
    //Referencia al transform del botón para terminar la prueba
    public Transform EndTestButtonTransform;
    //Objeto original del cual se va a copiar
    public GameObject TestObjectReference;
    //Transform del padre del cual estarán las copias
    public Transform parent;

    public void InstanceTestQuestions(Prueba test) {
        //Ciclo donde por cada pregunta de la prueba en la lista se crea una tarjeta nueva
        for (int i = 0; i < test.preguntas.Count; i++)
        {
            //Crea la nueva tarjeta
            GameObject newTestObject = GameObject.Instantiate(TestObjectReference, parent);

            //Asignar la pregunta a la tarjeta
            newTestObject.GetComponent<TestObjectBehaviour>().InitialzeTestObject(test.preguntas[i]);
        }
        EndTestButtonTransform.SetAsLastSibling();
    }

}
