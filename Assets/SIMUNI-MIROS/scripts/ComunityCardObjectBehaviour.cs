using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComunityCardObjectBehaviour : MonoBehaviour
{
    [Header("Description String Truncate Value")]
    public int stringTruncateValue = 0;

    [Header("University Card UI Objects")]
    public Text cardTitleText;
    public Text cardBodyText;
    //public Text cardCategory;

    private Univerisity university;

    //Método para asginar la referencia de la universidad
    public void SetUniversity(Univerisity value) {
        this.university = value;
    }

    //Método que coloca los datos de la univerisdad a la UI del panel
    public void SetUniversityData() {
        if (university != null) {
            cardTitleText.text = university.Name;
            cardBodyText.text = Truncate(university.Description, stringTruncateValue);
   
        }
    }

    //Acción al precionar este objeto
    public void CardButtonOnClick() {

        //OBTENER EL COMPONENTE DE UniversityDetailViewPanel PARA ASIGNAR LA INFORMACIÓN AL PANEL DE DETALLE
        UniversityDetailViewPanel universityDetailViewPanel = ScreenManager.instance.GetView(ViewID.UniversityDetailView).GetComponent<UniversityDetailViewPanel>();
        universityDetailViewPanel.SetUniversity(university);
        universityDetailViewPanel.SetUniversityData();

        //PARA CAMBIAR A LA PANTALLA DE DETALLE DE LA UNIVERSIDAD
        ScreenManager.instance.ChangeView(ViewID.UniversityDetailView, true);
    }

    public string Truncate(string value, int maxLength)
    {
        if (string.IsNullOrEmpty(value)) return value;
        value = value.Length <= maxLength ? value : value.Substring(0, maxLength);
        value = value + "...";
        return value;
    }

}
