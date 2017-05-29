using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneAction : GameAction
{

    public string targetScene;

    public override void DoAction()
    {
        SceneManager.LoadScene(targetScene);

    }
}
