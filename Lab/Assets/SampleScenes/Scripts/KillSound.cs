using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSound : MonoBehaviour
{
    AudioSource sourse;
    // Start is called before the first frame update
    void Start()
    {
        sourse = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!sourse.isPlaying){
            Destroy(gameObject);
        }
    }
}
