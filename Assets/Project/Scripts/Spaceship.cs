using UnityEngine;
using System.Collections;
using System;

public class Spaceship : MonoBehaviour
{
    private LaserWave laserWave;
    private LaserWaveRenderer laserWaveRenderer;
    private MusicManager musicManager;

    private void Start()
    {
        laserWave = GetComponentInChildren<LaserWave>();
        laserWaveRenderer = GetComponentInChildren<LaserWaveRenderer>();
        musicManager = FindObjectOfType<MusicManager>();

        Registry.musicManager.BeatPassed += MusicManager_BeatPassed;
    }

    private void MusicManager_BeatPassed(object sender, EventArgs e)
    {
		
    }

    private void Update()
    {
        if (musicManager.CheckRhythm() != RhythmState.awful)
        {
            if (Input.GetButtonDown("RightBumper"))
            {
                laserWave.Fire();
                laserWaveRenderer.SetVisible(true);
            }
        }
        else
        {
            laserWaveRenderer.SetVisible(false);
        }
    }
}
