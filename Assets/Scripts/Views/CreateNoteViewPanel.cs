using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CreateNoteViewPanel : View
{
    public InputField NoteTitle;
    public InputField NoteText;
    public Text dateText;

    private DateTime currentDate;

    public void SetCurrentDate(DateTime currentDate)
    {
        this.currentDate = currentDate;
        dateText.text = currentDate.ToString("dd/MM/yyyy");
    }

    public void AddNoteButtonOnClick()
    {
        Debug.Log("Se añadío la nota de " + NoteTitle.text);

        //1.- CREAR UNA NUEVA NOTA

        //Note newNote = new Note();
        //newNote.title = NoteTitle.text;
        //newNote.text = NoteText.text;
        //newNote.date = currentDate;

        //2.- AÑADIR NUEVA NOTA A LA LISTA QUE TIENE EL MANEJADOR DE NOTAS

        //GameObject.FindObjectOfType<NoteManager>().notes.Add(newNota);

        //3.- ABRIR PANEL DE LISTA DE NOTAS

        //ScreenManager.instance.ChangeView(ViewID.NoteView, false); [Abrir la pantalla de lista de notas]

        //4.- LLAMAR AL MANEJADOR PARA QUE CREE LA LISTA DE NOTAS CON LA NUEVA AÑADIDIA

        // GameObject.FindObjectOfType<NoteManager>().InstanceNotes();

    }
}
