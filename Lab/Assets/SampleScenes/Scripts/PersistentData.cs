using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    [SerializeField] string playerName;
    [SerializeField] int playerScore;
    [SerializeField] float gameVolume;
    public static PersistentData Instance;

    public void Awake()
    {
         if (Instance == null)
         {
            Instance = this;

            DontDestroyOnLoad(this);
        }
        else
            Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        playerName = "";
        playerScore = 0;
        gameVolume = 0.0f;
    }

    public void SetName(string name){
        playerName = name;
    }

    public void SetScore(int score){
        playerScore = score;
    }
    public void setVolume(float vol) {
        gameVolume = vol;
    }
    public string GetName(){
        return playerName;
    } 

    public int GetScore(){
        return playerScore;
    }
    public float getVolume() {
        return gameVolume;
    }
}