using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // adding ui from unity 
using UnityEngine.SceneManagement; // adding scene management from unity library


public class GameTimer : MonoBehaviour
{
    //f = float
    private float timer = 60f;
    int points = 0;

    [SerializeField]
    //declaring game objects
    private GameObject timerTxt, pointsTxt;



    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;//creating the timer itself

        //creating a text and adding the functions timer & points
        timerTxt.GetComponent<Text>().text = "Timer: " + timer;
        pointsTxt.GetComponent<Text>().text = "Pavlovas: " + points;
        //game over 

        //when timer reaches 0, call function gameover
        if (timer <= 0)
        {
            gameOver();

        }
    }

    //creating a add points function
        public void setPoints(int i)
        {
        points += i;
        }

    //when function game over is called, load scene 2
        void gameOver()
        {
        SceneManager.LoadScene(2);
        }

    }





   
