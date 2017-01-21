using UnityEngine;
using System.Collections;

public class Spaceship : MonoBehaviour
{
    private LaserWave laserWave;
    private LaserWaveRenderer laserWaveRenderer;

    private void Start()
    {
        laserWave = GetComponentInChildren<LaserWave>();
        laserWaveRenderer = GetComponentInChildren<LaserWaveRenderer>();
    }

    private void Update()
    {
        if (Registry.musicManager.CheckRhythm() != RhythmState.awful)
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
