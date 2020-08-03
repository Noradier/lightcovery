using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    private static GameDataManager gameDataManager;
    private RectTransform panel;
    [SerializeField] private float timer, deltaTime;
    [SerializeField] private Text timerText;
    
    // Start is called before the first frame update
    void Start()
    {
        gameDataManager = FindObjectOfType<GameDataManager>();
        if (gameDataManager == null)
            Destroy(gameObject);

        panel = transform.Find("Panel").GetComponent<RectTransform>();

        timerText = panel.Find("Timer").GetComponent<Text>();

        initStage();
    }

    void Update()
    {
        deltaTime = Time.deltaTime;

        updateTime();
    }

    private void initStage()
    {
        timer = 60f;

        float x = Random.Range(200, 600),
            y = Random.Range(113, 225),
            size = Random.Range(50, 100);
        
        for (int i = 0; i < gameDataManager.getDifficulty(); i++)
        {
            GameObject instance = Instantiate(gameDataManager.getTargetedObject(), panel);

            RectTransform instanceBody = instance.GetComponent<RectTransform>();
            instanceBody.position = new Vector2(x, y);
            instanceBody.sizeDelta = new Vector2(size, size);

            x = 200 + x * x % 401;
            y = 112.5f + y * y % 226;
            size = 50 + size * size % 51;
        }

        int numberOfObject = gameDataManager.getDifficulty() * 5;

        size = Random.Range(25, 50);

        for (int i = 0; i < gameDataManager.getDifficulty() * 4; i++)
        {
            GameObject instance = Instantiate(gameDataManager.getNonTargetedObject(), panel);

            RectTransform instanceBody = instance.GetComponent<RectTransform>();

            instanceBody.position = new Vector2(x, y);
            instanceBody.sizeDelta = new Vector2(size, size);
            instance.GetComponent<RawImage>().color = new Color(x / 600, y / 337.5f, size / 50);

            x = 200 + x * x % 401;
            y = 112.5f + y * y % 226;
            size = 25 + size * size % 26;
        }
    }

    private void updateTime()
    {
        timer -= deltaTime;

        if(timer < 0f)
        {
            gameDataManager.resetScore();
            SceneManagement.changeSceneStatic(5);
        }

        timerText.text = ((int)timer).ToString();
    }

    public static void isFinished()
    {
        if (gameDataManager.isFinished())
        {
            SceneManagement.changeSceneStatic(4);
        }
    }
}
