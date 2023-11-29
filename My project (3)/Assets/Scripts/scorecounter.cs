using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scorecounter : MonoBehaviour
{
    public static scorecounter instance;
    public Text playerScore;

    //public MenuController menuController;
    public int currentScore = 0;

    void Awake()
    {
        instance = this;
    }

    //Displays Score 
    void Start()
    {
        playerScore.text = currentScore.ToString() + "/2 Fixed Robots";
    }

    //Adds points whenever an enemy calls "Fix"
    public void AddPoints()
    {
        currentScore += 1;
        playerScore.text = currentScore.ToString() + "/2 Fixed Robots";
        if (currentScore >= 5)
        {
            //menuController.WinGame();
        }
    }
}
