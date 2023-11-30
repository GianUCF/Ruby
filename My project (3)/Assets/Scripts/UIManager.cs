using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    [SerializeField]
    TextMeshProUGUI RobotCounter;
    public int scoreCount;
    public GameObject Win;
    public GameObject Lose;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Win.SetActive(false);
            Lose.SetActive(false);
        }
    }

    public void UpdateRobotCounterUI()
    {
        RobotCounter.text = scoreCount.ToString();
    }


    // Update is called once per frame
    void Update()
    {
        if (scoreCount == 2 )
        {
            Win.SetActive(true);
        }
    }
}
