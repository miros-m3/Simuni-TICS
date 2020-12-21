using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuViewPanel : View
{
    public void UniversityButtonOnClick() {
        ScreenManager.instance.ChangeView(ViewID.UniversityView, true);
        ScreenManager.instance.GetMenuView().SetActive(false);
    }

    public void TestButtonOnClick()
    {

    }

    public void ForumButtonOnClick()
    {

    }
}
