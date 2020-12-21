using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class View : MonoBehaviour
{
    public ViewID id;

    public ViewID GetViewID() {
        return id;
    }

    public void SetActive(bool value) {
        this.gameObject.SetActive(value);
    }

}
