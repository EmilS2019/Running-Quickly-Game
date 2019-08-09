using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class MySceneManager
{

    public static void ResetLevel()
    {
        SceneManager.LoadScene(SceneManager.sceneCount - 1);
    }

}
