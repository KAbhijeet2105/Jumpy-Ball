﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;
    bool gameOver;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance == null)
        {
            instance = this;
        }
        else
        { 
        Destroy(this.gameObject);
    }
    }

	// Use this for initialization
	void Start () {
        gameOver = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart() 
    {
        UiManager.instance.GameStart();
    GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().startSpwaningPipes();

     }

    public void GameOver()
    {
        UiManager.instance.GameOver();
        ScoreManager.instance.StopScore();
        gameOver = false;
        GameObject.Find("PipeSpawner").GetComponent<PipeSpawner>().stopSpwaningPipes();

    }

}