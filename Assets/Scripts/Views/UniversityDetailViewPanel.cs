using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UniversityDetailViewPanel : View
{
    [Header("University Detail View Panel UI Objects")]
    public Text UniversityNameText;
    public Image UniverityPictureImage;
    public Text UniversityBodyText;
    public Text UniversityPhoneText;
    public Text UniversityAddressText;

    private Univerisity university;

    //Método para asginar la referencia de la universidad
    public void SetUniversity(Univerisity value)
    {
        this.university = value;
    }

    //Método que coloca los datos de la univerisdad a la UI del panel
    public void SetUniversityData()
    {
        if (university != null)
        {
            UniversityNameText.text = university.Name;
            //UniverityPictureImage.sprite = university.Picture;
            UniversityBodyText.text = university.Description;
            UniversityPhoneText.text = university.Phone;
            UniversityAddressText.text = university.Address;
        }
    }

}
