using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetedObject : MonoBehaviour
{
    public void onClick()
    {
        GameDataManager gameManager = FindObjectOfType<GameDataManager>();

        gameManager.increaseScore();
        LevelManager.isFinished();
        Destroy(gameObject);
    }
}
