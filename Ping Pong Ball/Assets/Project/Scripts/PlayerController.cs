using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Input keys")]
    public KeyCode upKey;
    public KeyCode downKey;
    

    [Space]
    [Header("Varaibles:")]
    public float moveMentSpeed;


    private Rigidbody2D rb;
    private Vector2 vector;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D> ();
        if (moveMentSpeed == 0) 
            moveMentSpeed = 10f;
        vector = new Vector2(0f, moveMentSpeed);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(upKey)) 
        {
            // Debug.Log("going up!!");
            rb.velocity = vector;
        } 
        else if(Input.GetKey(downKey))
        {
            // Debug.Log("going down!!");
            rb.velocity = -vector;
        }
        else
        {
            rb.velocity = 0 * vector;
        }        
    }
}
