using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnControl : MonoBehaviour
{
    //creating buttons
    public void LoadGame() // when button is pressed load scene 
    {
        SceneManager.LoadScene(1);
    }
    public void ReturnMainMenu() // when button is pressed load scene 
    {
        SceneManager.LoadScene(0);
    }
    public void CharacterScreen() // when button is pressed load scene 
    {
        SceneManager.LoadScene(3);
    }
    public void Settings() // when button is pressed load scene 
    {
        SceneManager.LoadScene(4);
    }
}
