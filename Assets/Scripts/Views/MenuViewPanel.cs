using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuViewPanel : View
{
    public void UniversityButtonOnClick() {
        ScreenManager.instance.ChangeView(ViewID.UniversityView, true);
        ScreenManager.instance.GetMenuView().SetActive(false);
        //ScreenManager.instance.ChangeView(ViewID.MyPostView, false);
        //ScreenManager.instance.ChangeView(ViewID.NuevoPostView, false);
    }

    public void NewPostViewButtonOnClick()
    {
        ScreenManager.instance.ChangeView(ViewID.UniversityView, true);
        ScreenManager.instance.GetMenuView().SetActive(false);
        ScreenManager.instance.ChangeView(ViewID.MyPostView, false);
        ScreenManager.instance.ChangeView(ViewID.NuevoPostView, false);
    }

    public void MyPostViewButtonOnClick()
    {
        //ScreenManager.currentView.SetActive(false);
        ScreenManager.instance.ChangeView(ViewID.UniversityView, true);
        ScreenManager.instance.GetMenuView().SetActive(false);
        ScreenManager.instance.ChangeView(ViewID.MyPostView, false);
        
    }


    public void TestButtonOnClick()
    {

    }

    public void ForumButtonOnClick()
    {

    }
}
