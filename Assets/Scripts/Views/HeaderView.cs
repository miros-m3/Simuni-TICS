using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeaderView : View
{
    public void BackButtonOnClick() {
        ScreenManager.instance.BackToPreviousView();
        if (!ScreenManager.instance.HasSubViews())
            ScreenManager.instance.GetMenuView().SetActive(true);
    }
}
