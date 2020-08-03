using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataManager : MonoBehaviour
{
    [SerializeField] private string playerName;
    [SerializeField] private int difficulty, score;
    private GameObject targetedObject, nonTargetedObject;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        targetedObject = Resources.Load("Prefabs/Targeted Object", typeof(GameObject)) as GameObject;
        nonTargetedObject = Resources.Load("Prefabs/Non Targeted Object", typeof(GameObject)) as GameObject;
        DontDestroyOnLoad(gameObject);
    }

    public int getDifficulty()
    {
        return difficulty;
    }

    public GameObject getTargetedObject()
    {
        return targetedObject;
    }

    public GameObject getNonTargetedObject()
    {
        return nonTargetedObject;
    }

    public void setDifficulty(int difficulty)
    {
        score = 0;
        this.difficulty = difficulty;
    }

    public bool isFinished()
    {
        if (difficulty == score)
            return true;
        else
            return false;
    }

    public void resetScore()
    {
        score = 0;
    }

    public void increaseScore()
    {
        score++;
    }

    public void destroySelf()
    {
        Destroy(gameObject);
    }
}
