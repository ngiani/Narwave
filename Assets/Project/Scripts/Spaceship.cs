using UnityEngine;
using System.Collections;
using System;

public class Spaceship : MonoBehaviour
{
    private bool firePressed = false;
    private int lastPressedBeat = 0;

    public static bool canPress = true;  

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
        //beat++;
        
    }

    private void Update()
    {
        if (debugText)
            debugText.text = MusicManager.numBeats + ". " + Registry.musicManager.CheckRhythm().ToString();

        firePressed = Input.GetKeyDown(KeyCode.Space);

        if (!firePressed && canPress && MusicManager.numAvvallamenti >= lastPressedBeat + 1 && lastPressedBeat >= 0)
        {
            laserWaveRenderer.SetVisible(false);
            lastPressedBeat = -1;
            // TODO: decrease multiplicator counter level of 1
        }

        if (firePressed && canPress)
        {
            canPress = false;
            lastPressedBeat = GetNearestBeat();
            if (Registry.musicManager.CheckRhythm() != RhythmState.awful)
            {
                laserWave.Fire();
                laserWaveRenderer.SetVisible(true);
                lastPressedBeat = GetNearestBeat();
            }
            else
            {
                // TODO: reset multiplicator counter
            }
        }
    }

    private int GetNearestBeat()
    {
        if (MusicManager.numBeats > MusicManager.numAvvallamenti)
            return MusicManager.numBeats;
        else
            return MusicManager.numBeats - 1;
    }
}
