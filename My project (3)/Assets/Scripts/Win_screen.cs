using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Win_screen : MonoBehaviour
{
    public GameObject endPanel;

    private AudioSource audioSource;


    bool gameHasEnded = false;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

    }


    //when you fix two robots
    public void WinScreen()
    {

        endPanel.SetActive(true);
        endPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "You Win! Game Created by: Paul Dingee, Gianfranco Caro, and Jamal Hampton";


    }

}
