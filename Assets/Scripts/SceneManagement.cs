using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void changeScene(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    public static void changeSceneStatic(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void returnToTitleScreen()
    {
        GameDataManager manager = FindObjectOfType<GameDataManager>();

        manager.destroySelf();

        changeScene(0);
    }
}
