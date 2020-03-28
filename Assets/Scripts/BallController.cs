using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float upforce;
    Rigidbody2D rb;
    bool started;
    public float rotation;
    bool GameOver;
	// Use this for initialization
	void Start () {
        GameOver = false;
        rb = GetComponent<Rigidbody2D>();
        started = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (!started)
        {      if (Input.GetMouseButtonDown(0))
            {
                started = true;
                rb.isKinematic = false;
                GameManager.instance.GameStart();


            }
        }

        else if(started && !GameOver){

            transform.Rotate(0,0,rotation);

        if (Input.GetMouseButtonDown(0))
            {        rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0,upforce));
            }

        }
    }//update function end


    void OnCollisionEnter2D(Collision2D col)
    {
        GameOver = true;
        GameManager.instance.GameOver();
        GetComponent<Animator>().Play("BallAnimation");

    }


    void OnTriggerEnter2D(Collider2D col) {
    
        if (col.gameObject.tag == "pipe" && !GameOver)
        {
            GameManager.instance.GameOver();
            GameOver = true;
            GetComponent<Animator>().Play("BallAnimation");

        }


    if(col.gameObject.tag=="ScoreChecker" && !GameOver)
    {

            ScoreManager.instance.IncrementScore();
    }
    
    }

}
