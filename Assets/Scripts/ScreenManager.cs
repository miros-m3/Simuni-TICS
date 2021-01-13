using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour {

    private const int MIN_BACK_STACK_COUNT = 1;

    private Stack<View> backViewStack;

    [Header("Views Array")]
    [SerializeField]
    private View[] views = null;

    [Header("Current View")]
    [SerializeField]
    private View currentView = null;

    [Header("Menu View")]
    [SerializeField]
    private View menuView = null;

    private static ScreenManager _instance;

    public static ScreenManager instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<ScreenManager>();
            }
            return _instance;
        }
    }

    private void Start()
    {
        backViewStack = new Stack<View>();
    }

    public void BackToPreviousView()
    {
        if (backViewStack.Count >= MIN_BACK_STACK_COUNT) {
            currentView.SetActive(false);
            currentView = backViewStack.Peek();
            backViewStack.Pop();
        }
        
    }

    public void ChangeView(ViewID viewID, bool isSubView = false)
    {
        SelectedChangeOfViews(viewID, currentView, views, backViewStack, isSubView);   
    }

    public void CloseView(ViewID viewID, bool isSubGameView = false)
    {
        if (isSubGameView)
            backViewStack.Push(currentView);

        foreach (View viewInstance in views)
        {
            if (((View)(viewInstance.GetComponent(typeof(View)))).GetViewID() == viewID)
            {
                //Close GameView;
                ((View)(viewInstance.GetComponent(typeof(View)))).SetActive(false);
            }
        }
    }

    public View GetView(ViewID viewID)
    {
        foreach (View viewInstance in views)
        {
            if (((View)(viewInstance.GetComponent(typeof(View)))).GetViewID() == viewID)
            {
                return viewInstance;
            }
        }
        
        return null;
    }

    public bool HasSubViews() {
        if (backViewStack.Count <= 0)
        {
            return false;
        }
        else {
            return true;
        }
    }

    public View GetMenuView() {
        return menuView;
    }

    private void SelectedChangeOfViews(ViewID viewID, View currentView, View[] views, Stack<View> viewStack, bool isSubView = false) {

        if (isSubView)
        {
            if (viewID != ((View)(currentView.GetComponent(typeof(View)))).GetViewID())
                viewStack.Push(currentView);
        }
        else
        {
            CloseViews();
            viewStack.Clear();
        }


        foreach (View viewInstance in views)
        {
            if (((View)(viewInstance.GetComponent(typeof(View)))).GetViewID() == viewID)
            {
                this.currentView = viewInstance;

                //Open current GameView
                ((View)(viewInstance.GetComponent(typeof(View)))).SetActive(true);
            }
        }
    }

    private void CloseViews()
    {
        foreach (View viewInstance in views)
        {
            //Close upper viewInstance
            ((View)(viewInstance.GetComponent(typeof(View)))).SetActive(false);
        }
    }


}