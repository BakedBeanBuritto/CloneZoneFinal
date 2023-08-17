using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public float timeLimit = 60f;
    public float restartDelay = 2f;
    public TMP_Text timerText;
    public TMP_Text messageText;

    private float currentTimeLimit;
    private bool levelCompleted = false;

    private void Start()
    {
        InitializeLevel();
        StartLevel();
    }

    private void InitializeLevel()
    {
        // You can add any additional initialization logic here
    }

    private void Update()
    {
        if (!levelCompleted)
        {
            currentTimeLimit -= Time.deltaTime;
            UpdateTimerDisplay();

            if (currentTimeLimit <= 0f)
            {
                EndLevel(false);
            }
            else if (currentTimeLimit <= 3f)
            {
                timerText.color = Color.red;
            }
        }
        else
        {
            restartDelay -= Time.deltaTime;

            if (restartDelay <= 0f)
            {
                RestartLevel();
            }
        }
    }

    private void StartLevel()
    {
        currentTimeLimit = timeLimit;
        levelCompleted = false;
        UpdateTimerDisplay();
        messageText.text = "";
        messageText.gameObject.SetActive(false);
        restartDelay = 0f;
    }

    private void UpdateTimerDisplay()
    {
        timerText.text = $"Time: {Mathf.Max(0, Mathf.Round(currentTimeLimit))}s";
    }

    private void EndLevel(bool success)
    {
        levelCompleted = true;
        if (success)
        {
            messageText.text = "Level Completed!";
        }
        else
        {
            messageText.text = "Time's Up!";
            messageText.gameObject.SetActive(true);
            timerText.gameObject.SetActive(false);
        }
        restartDelay = 2f;
    }

    private void RestartLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}