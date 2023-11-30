using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject endPanel;




    bool gameHasEnded = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


  

    //when score reaches 2 points

    public void WinGame()
    {

        endPanel.SetActive(true);
        endPanel.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "ou Win! Game Created by: Paul Dingee, Gianfranco Caro, and Jamal Hampton";


    }

}
