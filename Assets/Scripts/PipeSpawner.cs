using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public GameObject pipe;

    public float maxYpos;
    public float SpawnTime;


    // Use this for initialization
    void Start () {
      //  startSpwaningPipes();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void stopSpwaningPipes()
    {

        CancelInvoke("SpawnPipes");

    }

    public void startSpwaningPipes()
    {

        InvokeRepeating("SpawnPipes",0.2f,SpawnTime);
    
    }

    void SpawnPipes()
    {

        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(-maxYpos,maxYpos),0),Quaternion.identity);
       }



   


}
