using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteObjectBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LayoutRebuilder.ForceRebuildLayoutImmediate((RectTransform)this.transform);
    }

}
