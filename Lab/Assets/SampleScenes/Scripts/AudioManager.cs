using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    void Awake(){
        instance = this;
    }
    //public List<AudioClip> sfxLibrary;
    public AudioClip sfx_landing, sfx_jumping, sfx_shooting, sfx_popping;
    public AudioClip music_bgm;

    public GameObject soundObject;
    // private void Start()
    // {
    //     Resources.Load();
    // }
    public void PlaySFX(string sfxName)
    {
            switch (sfxName)
            {
                case "landing":
                    SoundObjectCreation(sfx_landing);
                    break;
                case "jumping":
                    SoundObjectCreation(sfx_jumping);
                    break;
                case "shoting":
                    SoundObjectCreation(sfx_shooting);
                    break;
                case "popping":
                    SoundObjectCreation(sfx_popping);
                    break;
                default:
                    break;
            }
    }

    void SoundObjectCreation(AudioClip clip)
    {
        GameObject newObject = Instantiate(soundObject, transform);
        newObject.GetComponent<AudioSource>().clip = clip;
        newObject.GetComponent<AudioSource>().Play();
    }

    public void PlayMusic(string musicName)
    {
            switch (musicName)
            {
                case "bgm":
                    SoundObjectCreation(music_bgm);
                    break;
                default:
                    break;
            }
    }
        void MusicObjectCreation(AudioClip clip)
    {
        GameObject newObject = Instantiate(soundObject, transform);
        newObject.GetComponent<AudioSource>().clip = clip;
        newObject.GetComponent<AudioSource>().loop = true;
        newObject.GetComponent<AudioSource>().Play();
    }
}
