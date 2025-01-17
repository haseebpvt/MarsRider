﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    public GameObject pausedUI;
    public GameObject pauseUI;
    public GameObject Player;
    AudioSource audioSource;
   
    public static bool isScoreStopped = false;
    void Start()
    {
        pausedUI.SetActive(false);
        pauseUI.SetActive(true);
        audioSource = Player.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerCollision.isDead == true)
        {
            pauseUI.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void Pause()
    {
        audioSource.mute = true;
        audioSource.loop = false;
        pauseUI.SetActive(false);
        Time.timeScale = 0;
        pausedUI.SetActive(true);
        isScoreStopped = true;
        
    }

    public void Resume()
    {
        audioSource.mute = false;
        audioSource.loop = true;
        pausedUI.SetActive(false);
        pauseUI.SetActive(true);
        Time.timeScale = 1;
        isScoreStopped = false;
    }
}
