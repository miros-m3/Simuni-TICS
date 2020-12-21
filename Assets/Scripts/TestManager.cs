using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    public TestViewPanel testViewPanel;
    public Prueba examenDeAptitud;

    private void Start()
    {
        testViewPanel.InstanceTestQuestions(examenDeAptitud);
    }

    //Calificar el examen
    public void GradeTest() {

        int AllCheckedCounter = 0;

        for (int i = 0; i < examenDeAptitud.preguntas.Count; i++) {
            for (int j = 0; j < examenDeAptitud.preguntas[i].incisos.Length; j++)
            {
                if (!examenDeAptitud.preguntas[i].incisos[j].esElegido)
                {
                    AllCheckedCounter++;
                }
            }

            if (AllCheckedCounter >= 4) {
                Debug.Log("Constesta todas las preguntas");
                return;
            }

            AllCheckedCounter = 0;
        }

        int ACounter = 0;
        int BCounter = 0;
        int CCounter = 0;
        int DCounter = 0;

        for (int i = 0; i < examenDeAptitud.preguntas.Count; i++) {

            if (examenDeAptitud.preguntas[i].incisos[0].esElegido) {
                ACounter++;
            }

            if (examenDeAptitud.preguntas[i].incisos[1].esElegido)
            {
                BCounter++;
            }

            if (examenDeAptitud.preguntas[i].incisos[2].esElegido)
            {
                CCounter++;
            }

            if (examenDeAptitud.preguntas[i].incisos[3].esElegido)
            {
                DCounter++;
            }
        }

        Debug.Log("A: " + ACounter + " | B: " + BCounter + " | C: " + CCounter + " | D: " + DCounter);

        //Saber en que materia debería quedar la persona dependiendo del resultado...

        if (ACounter > BCounter && ACounter > CCounter && ACounter > DCounter) {
            Debug.Log("ARQUITECTO");
            return;
        }

        if (BCounter > ACounter && BCounter > CCounter && BCounter > DCounter)
        {
            Debug.Log("BARRENDERO");
            return;
        }

        if (CCounter > ACounter && CCounter > BCounter && CCounter > DCounter)
        {
            Debug.Log("CAMIONERO");
            return;
        }

        if (DCounter > ACounter && DCounter > BCounter && DCounter > CCounter)
        {
            Debug.Log("DENTISTA");
            return;
        }

        if (ACounter == BCounter && ACounter > CCounter && ACounter > DCounter)
        {
            Debug.Log("AB");
            return;
        }

        if (ACounter > BCounter && ACounter == CCounter && ACounter > DCounter)
        {
            Debug.Log("AC");
            return;
        }

        if (ACounter > BCounter && ACounter > CCounter && ACounter == DCounter)
        {
            Debug.Log("AD");
            return;
        }

        if (ACounter == BCounter && ACounter == CCounter && ACounter > DCounter)
        {
            Debug.Log("ABC");
            return;
        }

        if (ACounter == BCounter && ACounter > CCounter && ACounter == DCounter)
        {
            Debug.Log("ABD");
            return;
        }

        if (ACounter > BCounter && ACounter == CCounter && ACounter == DCounter)
        {
            Debug.Log("ACD");
            return;
        }

        if (ACounter == BCounter && ACounter == CCounter && ACounter == DCounter)
        {
            Debug.Log("ABCD");
            return;
        }

        if (BCounter > ACounter && BCounter == CCounter && BCounter > DCounter)
        {
            Debug.Log("BC");
            return;
        }

        if (BCounter > ACounter && BCounter > CCounter && BCounter == DCounter)
        {
            Debug.Log("BD");
            return;
        }

        if (BCounter > ACounter && BCounter == CCounter && BCounter == DCounter)
        {
            Debug.Log("BCD");
            return;
        }

        if (CCounter > ACounter && CCounter == BCounter && CCounter == DCounter)
        {
            Debug.Log("BCD");
            return;
        }

    }

}
