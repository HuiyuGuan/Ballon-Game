using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class HighScores : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText1;
    [SerializeField] TextMeshProUGUI scoreText2;
    [SerializeField] TextMeshProUGUI scoreText3;
    [SerializeField] TextMeshProUGUI scoreText4;
    [SerializeField] TextMeshProUGUI scoreText5;
    [SerializeField] TextMeshProUGUI name1;
    [SerializeField] TextMeshProUGUI name2;
    [SerializeField] TextMeshProUGUI name3;
    [SerializeField] TextMeshProUGUI name4;
    [SerializeField] TextMeshProUGUI name5;



    void Start()
    {
        if (PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("1st"))
        {
            PlayerPrefs.SetInt("5th", PlayerPrefs.GetInt("4th"));
            PlayerPrefs.SetInt("4th", PlayerPrefs.GetInt("3rd"));
            PlayerPrefs.SetInt("3rd", PlayerPrefs.GetInt("2nd"));
            PlayerPrefs.SetInt("2nd", PlayerPrefs.GetInt("1st"));
            PlayerPrefs.SetInt("1st", PlayerPrefs.GetInt("score"));

            PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("name2", PlayerPrefs.GetString("name1"));
            PlayerPrefs.SetString("name1", PlayerPrefs.GetString("username"));


        }
        if (PlayerPrefs.GetInt("score") < PlayerPrefs.GetInt("1st") && PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("2nd"))
        {
            PlayerPrefs.SetInt("5th", PlayerPrefs.GetInt("4th"));
            PlayerPrefs.SetInt("4th", PlayerPrefs.GetInt("3rd"));
            PlayerPrefs.SetInt("3rd", PlayerPrefs.GetInt("2nd"));
            PlayerPrefs.SetInt("2nd", PlayerPrefs.GetInt("score"));
            PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("name2", PlayerPrefs.GetString("username"));

        }
        if (PlayerPrefs.GetInt("score") < PlayerPrefs.GetInt("2nd") && PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("3rd"))
        {
            PlayerPrefs.SetInt("5th", PlayerPrefs.GetInt("4th"));
            PlayerPrefs.SetInt("4th", PlayerPrefs.GetInt("3rd"));
            PlayerPrefs.SetInt("3rd", PlayerPrefs.GetInt("score"));
            PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("name3"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("username"));

        }
        if (PlayerPrefs.GetInt("score") < PlayerPrefs.GetInt("3rd") && PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("4th"))
        {
            PlayerPrefs.SetInt("5th", PlayerPrefs.GetInt("4th"));
            PlayerPrefs.SetInt("4th", PlayerPrefs.GetInt("score"));
            PlayerPrefs.SetString("name5", PlayerPrefs.GetString("name4"));
            PlayerPrefs.SetString("name4", PlayerPrefs.GetString("username"));
        }
        if (PlayerPrefs.GetInt("score") < PlayerPrefs.GetInt("4th") && PlayerPrefs.GetInt("score") > PlayerPrefs.GetInt("5th"))
        {
            PlayerPrefs.SetInt("5th", PlayerPrefs.GetInt("score"));
            PlayerPrefs.SetString("name5", PlayerPrefs.GetString("username"));
        }




        scoreText1.text = PlayerPrefs.GetInt("1st").ToString();
        scoreText2.text = PlayerPrefs.GetInt("2nd").ToString();
        scoreText3.text = PlayerPrefs.GetInt("3rd").ToString();
        scoreText4.text = PlayerPrefs.GetInt("4th").ToString();
        scoreText5.text = PlayerPrefs.GetInt("5th").ToString();
        name1.text = PlayerPrefs.GetString("name1");
        name2.text = PlayerPrefs.GetString("name2");
        name3.text = PlayerPrefs.GetString("name3");
        name4.text = PlayerPrefs.GetString("name4");
        name5.text = PlayerPrefs.GetString("name5");


    }
    public void ClosedHighScores(){
        SceneManager.LoadScene("MainMenu");
    }
}
