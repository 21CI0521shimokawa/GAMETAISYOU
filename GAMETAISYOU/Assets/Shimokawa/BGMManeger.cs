using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManeger : MonoBehaviour
{
    private static BGMManeger instance;

    [SerializeField] AudioClip[] BGMs;
    [SerializeField] AudioSource BGMAudios;
    private void Awake()
    {
        if(instance==null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        BGMAudios.Play();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeBGM();
    }
    private void ChangeBGM()
    {
        // 現在のsceneを取得
        string SceneName = SceneManager.GetActiveScene().name;
        if(SceneName=="Title")
        {
            BGMAudios.clip = BGMs[0];
            if (BGMAudios.isPlaying == false)
            {
                BGMAudios.Play();
            }
        }
        else if(SceneName=="S2-1")
        {
            BGMAudios.clip = BGMs[1];
            if (BGMAudios.isPlaying == false)
            {
                BGMAudios.Play();
            }
        }
        else if(SceneName=="S3-1")
        {
            BGMAudios.clip = BGMs[2];
            if (BGMAudios.isPlaying == false)
            {
                BGMAudios.volume = 0.1f;
                BGMAudios.Play();
            }
        }
        else if(SceneName=="S4-1")
        {
            Destroy(gameObject);
        }
    }
}
