using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
 
public class GameManager : MonoBehaviour
{
    public int ScoreNum = 0;
    public int score;
    public int level;
    public int scoreForThisLevel = 1;
    const int ScorePerLevel = 1;
    [SerializeField] TextMeshProUGUI ScoreOutput;
    [SerializeField] TextMeshProUGUI levelOutput;
    [SerializeField] TextMeshProUGUI nameOutput;
    // Start is called before the first frame update
    void Start()
    {
        score = PersistentData.Instance.GetScore();
        level = SceneManager.GetActiveScene().buildIndex;
        displayName();
        displayScore();
    }
    void Update(){
        ScoreOutput.text = "Score : " + ScoreNum;
    }
    // Update is called once per frame
    public void AddScore(){
        ScoreNum++;
        ScoreOutput.text = "Score : " + ScoreNum;
        PersistentData.Instance.SetScore(ScoreNum);

        if (ScoreNum >= scoreForThisLevel)
        {
            SceneManager.LoadScene("Level" + 1);
        }
    }
    void displayScore(){
        ScoreOutput.text = "Score : " + ScoreNum;
    }
    void displayName(){
        nameOutput.text = "name : " + PersistentData.Instance.GetName();
    }
}
