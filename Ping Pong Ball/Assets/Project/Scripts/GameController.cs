using System.Collections;
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
    }
}
