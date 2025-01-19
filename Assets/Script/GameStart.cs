using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Collections;

public class GameStart : MonoBehaviour
{
    public GameObject startPromptText;

    private bool gameStarted = false; 

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;

        if (startPromptText != null)
        {
            startPromptText.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !gameStarted)
        {
            StartGame();
        }
    }
    
    void StartGame()
    {
        gameStarted = true;

        if (startPromptText != null)
        {
            startPromptText.SetActive(false);
        }

        Time.timeScale = 1f;
    }
}
