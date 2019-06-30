﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGameOver : MonoBehaviour
{

    private GameObject _windScoreUI;

    public GameObject windScoreUI { get; internal set; }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        windScoreUI = GameObject.Find("WinScreen");
        windScoreUI.SetActive(false);
    }

    public void showWintitle(int playerNumber)
    {
        // stops the running game
        GameObject gameManager = GameObject.Find("GameManager");
        AudioSource backgroundSound = gameManager.GetComponent<AudioSource>();
        backgroundSound.enabled = false;

        GameObject ball = GameObject.Find("Ball");
        ball.SetActive(false);


        // display the title screen
        this.windScoreUI.SetActive(true);    

        Debug.Log(gameManager);
        Debug.Log(ball);
    }
}
