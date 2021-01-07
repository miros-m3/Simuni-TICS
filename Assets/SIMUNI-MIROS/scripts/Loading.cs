using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Loading : MonoBehaviour
{ 
    public GameObject Pantalla_inicio;
    public GameObject RC_form;
    public GameObject Iniciarsesion;
    public GameObject OlvideContraseña;
    public GameObject RC_imagen;

    // Start is called before the first frame update

    private void Start()
    {
        new WaitForSeconds(250);
        Pantalla_inicio.SetActive(true);
    }


    public void BTN_RC_form()
    {
        RC_form.SetActive(true);
        Iniciarsesion.SetActive(false);
        OlvideContraseña.SetActive(false);
    }
    public void BTN_RC_imagen()
    {
        RC_imagen.SetActive(true);
        Iniciarsesion.SetActive(false);
        OlvideContraseña.SetActive(false);
        RC_form.SetActive(false);

    }

    public void BTN_Iniciarsesion()
    {
        Iniciarsesion.SetActive(true);
        OlvideContraseña.SetActive(false);
        RC_form.SetActive(false);
    }

    public void BTN_Pantalla_inicio()
    {
        Pantalla_inicio.SetActive(true);
        OlvideContraseña.SetActive(false);
        RC_form.SetActive(false);
        RC_imagen.SetActive(false);
        Iniciarsesion.SetActive(false);
    }

    public void BTN_OlvideContraseña()
    {
        OlvideContraseña.SetActive(true);
        Iniciarsesion.SetActive(false);
        RC_form.SetActive(false);
    }



}