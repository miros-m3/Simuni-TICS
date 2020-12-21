using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSceneTransitionPanel : MonoBehaviour
{
    public bool scene1;

    public void ChangeScene() {
        if (scene1)
        {
            SceneTransitionManager.instance.startLoadScene("SceneTransition2");
        }
        else {
            SceneTransitionManager.instance.startLoadScene("SceneTransition1");
        }
    }

}
