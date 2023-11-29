using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RestartTextEnable : MonoBehaviour
{
public int health { get { return currentHealth; }}
    int currentHealth;
    public Text RestartText;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
            if (currentHealth <= 0)
    {
       RestartText.text  = "R to Restart";
    }
    }

}
