using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawn : MonoBehaviour
{
    [SerializeField] GameObject balloonPrefab;    
    const int NUM_Ballons = 5;
    public float MaxTime = 10f;
    float CurrentTime = 0;
        int xMin = -21;
        int xMax = 0;
        int yMin = 0;
        int yMax = 8;
    void Start(){

    }

void Update(){
    CurrentTime += Time.deltaTime;
    if(CurrentTime>=MaxTime){
	    CurrentTime = 0f;
            Vector2 position = new Vector2(Random.Range(xMin, xMax), Random.Range(yMin, yMax));
            Instantiate(balloonPrefab, position, Quaternion.identity);
}}


    // void Spawn()
    // {


    //     //Instantiate(balloonPrefab, transform.position, transform.rotation);
    // }
}
