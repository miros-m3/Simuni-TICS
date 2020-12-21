using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Univerisity
{
    public string Name;
    [TextArea(10, 10)]
    public string Description;
    public Sprite Picture;
    public string Address;
    public string Phone;
}
