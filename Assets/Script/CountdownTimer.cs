using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;  


public class CountdownTimer : MonoBehaviour
{
    public float startTime = 10f; 
    public TMP_Text timerText; 
    public GameObject gameOverPanel;
    public AudioSource gameOverSound;

    private float currentTime;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        gameOverPanel.SetActive(false);

        if (gameOverSound != null)
        {
            gameOverSound.loop = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        timerText.text = Mathf.Clamp(currentTime, 0, startTime).ToString("F1");

        if (currentTime <=0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);

        if (gameOverSound != null && !gameOverSound.isPlaying)
        {
            gameOverSound.Play();
            StartCoroutine(StopSoundAfterPlay());
            gameOverSound.loop = false;
        }

        Time.timeScale = 0f;
    }
    
    public void QuitGame()
    {
        Debug.Log("Quitting the game...");
        Application.Quit();
    }

    private IEnumerator StopSoundAfterPlay()
    {
        yield return new WaitForSeconds(gameOverSound.clip.length);
        gameOverSound.Stop();
    }
}
