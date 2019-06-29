using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGameOver : MonoBehaviour
{
    static public void showWintitle(int playerNumber)
    {
        GameObject gameManager = GameObject.Find("GameManager");
        AudioSource backgroundSound = gameManager.GetComponent<AudioSource>();
        backgroundSound.enabled = false;

        GameObject ball = GameObject.Find("Ball");
        ball.SetActive(false);

        Debug.Log(gameManager);
        Debug.Log(ball);
    }
}
