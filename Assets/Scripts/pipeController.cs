using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeController : MonoBehaviour {


    public float speed;
    public float upDownspeed;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        MovePipe();
        InvokeRepeating("SwitchUpDown",1f,1f);
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void SwitchUpDown()
    {

        upDownspeed = -upDownspeed;
        rb.velocity = new Vector2(-speed, upDownspeed);
    }

    void MovePipe()
    {
        rb.velocity = new Vector2(-speed,upDownspeed);
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "PipeRemover")
        {

            Destroy(gameObject);

        }



    }



}
