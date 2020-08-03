using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectionManager : MonoBehaviour
{
    public void setGameDifficultyEasy()
    {
        GameDataManager manager = FindObjectOfType<GameDataManager>();

        manager.setDifficulty(1);
        SceneManagement.changeSceneStatic(3);
    }

    public void setGameDifficultyNormal()
    {
        GameDataManager manager = FindObjectOfType<GameDataManager>();

        manager.setDifficulty(4);
        SceneManagement.changeSceneStatic(6);
    }

    public void setGameDifficultyHard()
    {
        GameDataManager manager = FindObjectOfType<GameDataManager>();

        manager.setDifficulty(10);
        SceneManagement.changeSceneStatic(7);
    }

    public void openMainGameScreen()
    {
        SceneManagement.changeSceneStatic(3);
    }
}
