using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject name;
    public string playerName;
    
    void Update()
    {

    }
    
    public void OpenSetting(){
        SceneManager.LoadScene("Setting");
    }
    public void OpenInstructions(){
        SceneManager.LoadScene("Instructions");
    }
    public void OpenHighScores(){
        SceneManager.LoadScene("HighScores");
    }
    public void StartGame()
    {
        PlayerPrefs.SetString("username", playerName);
        SceneManager.LoadScene("Level1");
    }
    public void ClosedInstructions(){
        SceneManager.LoadScene("MainMenu");
    }
    public void ClosedHighScores(){
        SceneManager.LoadScene("MainMenu");
    }
    public void ClosedSetting(){
        SceneManager.LoadScene("MainMenu");
    }
}
