using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter instance;
    public Text playerScore;
    public GameObject endPanel;

    public int currentScore = 0;
    public MenuController menuController;

    void Awake()
    {
        instance = this;
    }

    //Displays Score 
    void Start()
    {
        playerScore.text = currentScore.ToString() + "/5 Robots Fixed";
    }

    //Adds points whenever an enemy calls "Fix"
    public void AddPoints()
    {
        currentScore += 1;
        playerScore.text = currentScore.ToString() + "/5 Robots Fixed";
        if (currentScore >= 5)
        {
            endPanel.SetActive(true);
            endPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You Win! Press R to restart!";
        }
    }
}