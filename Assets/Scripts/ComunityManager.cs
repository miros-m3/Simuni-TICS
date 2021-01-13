using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComunityManager : MonoBehaviour
{
    public ComunityViewPanel ComunityViewPanel;
    public UniversityDetailViewPanel universityDetailViewPanel;

    public List<Univerisity> universities;

    private void Start()
    {
        ComunityViewPanel.InstanceUniversityCards(universities);
    }

}
