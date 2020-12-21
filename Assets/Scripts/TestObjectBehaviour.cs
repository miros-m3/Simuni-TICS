using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestObjectBehaviour : MonoBehaviour
{
    public Text title;
    public Toggle incisoA;
    public Toggle incisoB;
    public Toggle incisoC;
    public Toggle incisoD;

    private Pregunta currentQuestion;

    private void Start()
    {
        incisoA.onValueChanged.AddListener(OnValueChangedToggleA);
        incisoB.onValueChanged.AddListener(OnValueChangedToggleB);
        incisoC.onValueChanged.AddListener(OnValueChangedToggleC);
        incisoD.onValueChanged.AddListener(OnValueChangedToggleD);
    }

    public void InitialzeTestObject(Pregunta pregunta) {

        currentQuestion = pregunta;

        title.text = pregunta.pregunta;
        incisoA.GetComponentInChildren<Text>().text = pregunta.incisos[0].respuesta;
        incisoB.GetComponentInChildren<Text>().text = pregunta.incisos[1].respuesta;
        incisoC.GetComponentInChildren<Text>().text = pregunta.incisos[2].respuesta;
        incisoD.GetComponentInChildren<Text>().text = pregunta.incisos[3].respuesta;
    }

    public Pregunta GetCurrentQuestion() {
        return currentQuestion;
    }

    private void OnValueChangedToggleA(bool value) {
        if (value) {
            currentQuestion.incisos[0].esElegido = true;
            currentQuestion.incisos[1].esElegido = false;
            currentQuestion.incisos[2].esElegido = false;
            currentQuestion.incisos[3].esElegido = false;
            incisoB.isOn = false;
            incisoC.isOn = false;
            incisoD.isOn = false;
        }
    }

    private void OnValueChangedToggleB(bool value)
    {
        if (value)
        {
            currentQuestion.incisos[1].esElegido = true;
            currentQuestion.incisos[0].esElegido = false;
            currentQuestion.incisos[2].esElegido = false;
            currentQuestion.incisos[3].esElegido = false;
            incisoA.isOn = false;
            incisoC.isOn = false;
            incisoD.isOn = false;
        }
    }

    private void OnValueChangedToggleC(bool value)
    {
        if (value)
        {
            currentQuestion.incisos[2].esElegido = true;
            currentQuestion.incisos[0].esElegido = false;
            currentQuestion.incisos[1].esElegido = false;
            currentQuestion.incisos[3].esElegido = false;
            incisoA.isOn = false;
            incisoB.isOn = false;
            incisoD.isOn = false;
        }
    }

    private void OnValueChangedToggleD(bool value)
    {
        if (value)
        {
            currentQuestion.incisos[3].esElegido = true;
            currentQuestion.incisos[0].esElegido = false;
            currentQuestion.incisos[1].esElegido = false;
            currentQuestion.incisos[2].esElegido = false;
            incisoA.isOn = false;
            incisoB.isOn = false;
            incisoC.isOn = false;
        }
    }

}
