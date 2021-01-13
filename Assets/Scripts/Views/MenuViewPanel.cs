using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuViewPanel : View
{
    public void UniversityButtonOnClick() {
        ScreenManager.instance.ChangeView(ViewID.UniversityView, true);
        ScreenManager.instance.GetMenuView().SetActive(false);
    }

    public void NewPostButtonOnClick()
    {
        ScreenManager.instance.ChangeView(ViewID.NuevoPost, true);
        ScreenManager.instance.GetMenuView().SetActive(false);
        ScreenManager.instance.ChangeView(ViewID.UniversityView, false);
    }


    public void TestButtonOnClick()
    {

    }

    public void ForumButtonOnClick()
    {

    }
}
