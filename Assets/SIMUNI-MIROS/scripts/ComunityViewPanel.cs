using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComunityViewPanel : View
{
    //Objeto original del cual se va a copiar
    public GameObject CardObjectReference;
    //Transform del padre del cual estarán las copias
    public Transform parent;

    public void InstanceUniversityCards(List<Univerisity> univerisities) {
        //Antes de crear nuevas tarjetas de univerisdades, vamos a limpiar la lista
        DeleteUniversityCards();

        //Ciclo donde por cada universidad en la lista se crea una tarjeta nueva
        for (int i = 0; i < univerisities.Count; i++) {
            //Crea la nueva tarjeta
            GameObject newCardObject = GameObject.Instantiate(CardObjectReference, parent);

            //Capturar el componenete CardObjectBehaviour
            ComunityCardObjectBehaviour newCardObjectBahaviour = newCardObject.GetComponent<ComunityCardObjectBehaviour>();

            //Pasar la información de la Univerisidad respectiva
            newCardObjectBahaviour.SetUniversity(univerisities[i]);
            newCardObjectBahaviour.SetUniversityData();
        }
    }

    public void DeleteUniversityCards() {
        if (parent.childCount <= 0)
            return;

        for (int i = 0; i < parent.childCount; i++) {
            Destroy(parent.GetChild(i).gameObject);
        }
    }

}
