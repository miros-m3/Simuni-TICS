using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine.UI;

public class Comunidades_PanelControler : MonoBehaviour
{
    //COMUNITY PANELS
    public GameObject Comunidad;
    public GameObject NuevoPost;
    public GameObject ComentarioDetalle;


    //MENU PANELS

    //NEWPOST INPUTS
    public InputField PostTitle;
    public InputField PostCategoria;
    public InputField PostText;

    public void BTN_Comunidad()
    {
        Comunidad.SetActive(true);

    }
    public void BTN_NuevoPost()
    {
        NuevoPost.SetActive(true);

    }
    public void BTN_ComentarioDetalle()
    {
        ComentarioDetalle.SetActive(true);

    }

    public void Create_Post()
    {
        string String_PostTitle = PostTitle.text;
        string String_PostCategoria = PostCategoria.text;
        string String_Posttext = PostText.text;



    }

}
