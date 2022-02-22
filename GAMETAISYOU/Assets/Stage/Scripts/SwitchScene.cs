using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public static class SwitchScene
{
    //現在のシーンを再起動する
    public static void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
