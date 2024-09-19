using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;
    bool gameOver = false;

    int score = 0;
    public Text textScore;
    public GameObject panel;

    private void Awake()
    {
        instance = this;
        panel.SetActive(false);
        gameOver = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOver = true;

        GameObject.Find("ObstacleSpawner").GetComponent<ObstacleSpawner>().StopSpawning();

        panel.SetActive(true);
    }

    public void IncrementScore()
    {
        if (!gameOver)
        {
            score++;
            textScore.text = score.ToString();
            print(score);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
