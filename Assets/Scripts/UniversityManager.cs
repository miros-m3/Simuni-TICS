using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversityManager : MonoBehaviour
{
    public UniversitiesViewPanel universitiesViewPanel;
    public UniversitiesViewPanel MyPostViewPanel;
    public UniversityDetailViewPanel universityDetailViewPanel;

    public List<Univerisity> universities;

    private void Start()
    {
        universitiesViewPanel.InstanceUniversityCards(universities);
        MyPostViewPanel.InstanceUniversityCards(universities);
    }

}
