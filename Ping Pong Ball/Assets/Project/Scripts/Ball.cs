using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Invoke("goBall", 2f);
    }

    void resetBall() 
    {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        this.GetComponent<Rigidbody2D>().position = new Vector2(0f, 0f);
        Invoke("goBall", 0.5f);
    }

    void goBall() 
    {
        float choice = Random.Range(0f, 1f);
        this.GetComponent<Rigidbody2D>().AddForce(new Vector2(choice <= 0.5 ? 40f : -40f, 50f));
    }

    /// <summary>
    /// OnCollisionEnter is called when this collider/rigidbody has begun
    /// touching another rigidbody/collider.
    /// </summary>
    /// <param name="other">The Collision data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "Player")
        {
            // script for the movement as per the distance of the contact
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(
                                                            -this.GetComponent<Rigidbody2D>().velocity.x,
                                                            (other.collider.GetComponent<Rigidbody2D>().velocity.y / 2) + 
                                                            (this.GetComponent<Rigidbody2D>().velocity.y /3));
        }
    }

    /// <summary>
    /// Sent when another object enters a trigger collider attached to this
    /// object (2D physics only).
    /// </summary>
    /// <param name="other">The other Collider2D involved in this collision.</param>
    void OnTriggerEnter2D(Collider2D other)
    {
        GameController.addScoreTo(other.name);
        resetBall();
    }
}
