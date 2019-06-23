﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [Header("Camera: ")]
    public Camera cam;

    [Header("Walls: ")]
    public BoxCollider2D topWall;
    public BoxCollider2D bottomWall;
    public BoxCollider2D leftWall;
    public BoxCollider2D rightWall;
    
    [Header("Players: ")]
    public Transform player1;
    public Transform player2;

    [Header("Skins: ")]
    public GUISkin skin;

    // private varables
    static private int player1Score{get; set;}
    static private int player2Score{get; set;}

    // Update is called once per frame
    void Start()
    {
        // seting the scale for all walls
        // for top wall
        topWall.size = new Vector2(cam.ScreenToWorldPoint(new Vector3(Screen.width *2f, 0f, 0f)).x, 1f);  
        topWall.offset = new Vector2(0f, cam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y + 0.5f);

        // for bottom wall
        bottomWall.size = new Vector2(cam.ScreenToWorldPoint(new Vector3(Screen.width * 2f, 0f, 0f)).x, 1f);
        bottomWall.offset = new Vector2(0f, -cam.ScreenToWorldPoint(new Vector3(0f, Screen.height, 0f)).y - 0.5f);

        // for left wall
        leftWall.size = new Vector2(1f, cam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        leftWall.offset = new Vector2(-cam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x - 0.5f, 0f);

        // for right wall
        rightWall.size = new Vector2(1f, cam.ScreenToWorldPoint(new Vector3(0f, Screen.height * 2f, 0f)).y);
        rightWall.offset = new Vector2(cam.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f)).x + 0.5f, 0f);

        // set the position of the players
        player1.position = new Vector2(cam.ScreenToWorldPoint(new Vector3(75f, 0f, 0f)).x, 0f);
        player2.position = new Vector2(cam.ScreenToWorldPoint(new Vector3(Screen.width - 75f, 0f, 0f)).x, 0f);

        // initializing the scores
        player1Score = 0;
        player2Score = 0;
    }

    /// <summary>
    /// OnGUI is called for rendering and handling GUI events.
    /// This function can be called multiple times per frame (one call per event).
    /// </summary>
    void OnGUI()
    {
        GUI.skin = this.skin;
        GUI.Label(new Rect(Screen.width / 2 - 175, 20, 200, 200), "player 1: " + player1Score);
        GUI.Label(new Rect(Screen.width / 2 + 175, 20, 200, 200), "player 2: " + player2Score);
    }

    public static void addScoreTo(string name)
    {
        if(name == "Left Wall")
        {
            player2Score += 1;
        }
        else if(name == "Right Wall")
        {
            player1Score += 1;
        }
        Debug.Log("player 1 Score: " + player1Score);
        Debug.Log("player 2 Score: " + player2Score);
    }
}
