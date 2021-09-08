using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    public bool startPlaying;
    public BeatScroller theBS;
    public main m;

    void Start()
    {
        
    }

    void Update()
    {
        if (!startPlaying && m.levelDone == false)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        } else if (m.levelDone == true)
        {
            startPlaying = false;
            theBS.hasStarted = false;

            theMusic.Stop();
        }
    }
    public void NoteHit()
    {

    }
}
