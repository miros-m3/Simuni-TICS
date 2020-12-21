using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DayButton : MonoBehaviour
{

    public DateTime currentDate;

    public void DayButtonOnClick() {

        ScreenManager.instance.ChangeView(ViewID.CreateNoteView, true);
        ScreenManager.instance.GetView(ViewID.CreateNoteView).GetComponent<CreateNoteViewPanel>().SetCurrentDate(currentDate);
    }
}
