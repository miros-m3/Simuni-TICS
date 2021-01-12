using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Comunidades_PanelControler : MonoBehaviour
{
    //COMUNITY PANELS
    public GameObject Comunidad;
    public GameObject NuevoPost;
    public GameObject ComentarioDetalle;


    //MENU PANELS

    //NEWPOST INPUTS

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

}
