using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UiManager : MonoBehaviour {

    public static UiManager instance;
    public Text ScoreText;
    public Text HighScoreText;

    public GameObject GameOverPanel;
    public GameObject StartUI;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    
    }

	// Use this for initialization
	void Start () {
		
	}
	// Update is called once per frame
	void Update () {

        ScoreText.text = ScoreManager.instance.score.ToString();
	}


    public void GameOver()
    {
        GameOverPanel.SetActive(true);

        HighScoreText.text = "High Score:"+PlayerPrefs.GetInt("HighScore").ToString();
     
    }

    public void Replay()
    {
        SceneManager.LoadScene("level1");
    
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");

    }


    public void GameStart()
    {
        StartUI.SetActive(false);

    }


}
