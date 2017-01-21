using UnityEngine;
using System.Collections;
using System;

public class Spaceship : MonoBehaviour
{
    private bool firePressed = false;
    private int beat = 1;
    private int lastPressedBeat = 0;

    private LaserWave laserWave;
    private LaserWaveRenderer laserWaveRenderer;

    public UnityEngine.UI.Text debugText;

    private void Start()
    {
        laserWave = GetComponentInChildren<LaserWave>();
        laserWaveRenderer = GetComponentInChildren<LaserWaveRenderer>();

        Registry.musicManager.BeatPassed += MusicManager_BeatPassed;
    }

    private void MusicManager_BeatPassed(object sender, EventArgs e)
    {
        beat++;
        if (!firePressed)
        {
            laserWaveRenderer.SetVisible(false);
            // TODO: decrease multiplicator counter level of 1
        }
    }

    private void Update()
    {
        if (debugText)
            debugText.text = beat + ". " + Registry.musicManager.CheckRhythm().ToString();

        firePressed = Input.GetKeyDown(KeyCode.Space);
        if (firePressed)
        {
            if (Registry.musicManager.CheckRhythm() != RhythmState.awful && lastPressedBeat != beat)
            {
                laserWave.Fire();
                laserWaveRenderer.SetVisible(true);
                lastPressedBeat = beat;
            }
            else
            {
                // TODO: reset multiplicator counter
            }
        }
    }
}
