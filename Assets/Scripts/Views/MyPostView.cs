using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPostView : View
{
    public GameObject Panel;

    public void MyPost_ON ()
    {
        Panel.SetActive(true);
    }
    public void MyPost_OFF()
    {
        Panel.SetActive(false);
    }
}
