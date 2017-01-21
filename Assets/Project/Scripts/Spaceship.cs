using UnityEngine;
using System.Collections;

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
