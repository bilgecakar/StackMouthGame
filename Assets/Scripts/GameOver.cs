using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{

    public static GameOver instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {        
        GetComponent<Text>().enabled = false;
        //When the game starts, the text will be invisible, only if the game is over, the text will be visible
    }

    public void Finish()
    {
        //If only the main object remains in the list and player is collide the cactus
        //Game over
        GetComponent<Text>().enabled = true;
        Time.timeScale = 0;
        
    }
}
