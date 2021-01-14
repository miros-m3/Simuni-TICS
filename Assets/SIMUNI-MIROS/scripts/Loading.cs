using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    //PANELS
    public GameObject Pantalla_inicio;
    public GameObject RC_form;
    public GameObject Iniciarsesion;
    public GameObject OlvideContraseña;
    public GameObject RC_imagen;

    //PopUp
    public GameObject No_correo;
    public GameObject No_password;
    public GameObject No_RC;
    public GameObject No_diferentpassword;
    public GameObject No_olvide;

    //INPUTS INICIAR SESION
    public InputField Correo;
    public InputField password;

    // INPUTS REGISTRAR CUENTA
    public InputField RC_I_nombre;
    public InputField RC_I_correo;
    public InputField RC_I_password;
    public InputField RC_I_password2;

    // INPUT OLVIDE CONTRASEÑA
    public InputField OC_I_correo;

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
        RC_imagen.SetActive(false);
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

    public void LoadApp()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        UnityEngine.SceneManagement.SceneManager.LoadScene("ComunityBeta", LoadSceneMode.Single);
    }

    public void LogIn()
    {
        if (Correo.text.Equals("ejemplo@gmail.com"))
        {
            if (password.text.Equals("123"))
            {
                LoadApp();
                return;
            }
            else
            {
                No_password.SetActive(true);
            }
        }
        else
        {
            No_correo.SetActive(true);
        }
    }

    public void Close_PopUp()
    {

        No_correo.SetActive(false);
        No_diferentpassword.SetActive(false);
        No_password.SetActive(false);
        No_RC.SetActive(false);
        No_olvide.SetActive(false);

    }



    //No_RC.SetActive(true);

    public void RC_fillform()
    {
        {
            string RC_String_nombre = RC_I_nombre.text;
            string RC_String_correo = RC_I_correo.text;
            string RC_String_password = RC_I_password.text;
            string RC_String_password2 = RC_I_password2.text;
            if (!string.IsNullOrWhiteSpace(RC_String_nombre))
            {

                if (!string.IsNullOrWhiteSpace(RC_String_correo))
                {
                    if (!string.IsNullOrWhiteSpace(RC_String_password))
                    {
                        if (!string.IsNullOrWhiteSpace(RC_String_password2))
                        {

                            if (RC_String_password == RC_String_password2)
                            {
                                BTN_RC_imagen();

                            }
                            else { No_diferentpassword.SetActive(true); }
                        }
                        else { No_RC.SetActive(true); }

                    }
                    else { No_RC.SetActive(true); }
                }
                else
                {
                    No_RC.SetActive(true);
                }
            }
            else
            {
                No_RC.SetActive(true);
            }
        }
    }

    public void OC_fillform()
    {
        

            string OC_String_correo = OC_I_correo.text;
            if (string.IsNullOrWhiteSpace(OC_String_correo))
            {
                No_RC.SetActive(true);

            }
            else
            {
                No_olvide.SetActive(true);
            }

        
    }

}