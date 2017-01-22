using UnityEngine;
using System.Collections;
using System;

public class Spaceship : MonoBehaviour
{
    private bool firePressed = false;
    private int lastPressedBeat = 0;

    private bool canPress = true;  

    private LaserWave laserWave;
    private LaserWaveRenderer laserWaveRenderer;
    private InputController inputController;
    private BoxCollider laserCollider;

    public UnityEngine.UI.Text debugText;

    private void Start()
    {
        laserWave = GetComponentInChildren<LaserWave>();
        laserWaveRenderer = GetComponentInChildren<LaserWaveRenderer>();
        inputController = GetComponent<InputController>();
        laserCollider = laserWave.GetComponent<BoxCollider>();

        Registry.musicManager.BeatPassed += MusicManager_BeatPassed;
        Registry.musicManager.NearestBeatChanged += MusicManager_NearestBeatChanged;
    }

    private void MusicManager_NearestBeatChanged(object sender, EventArgs e)
    {
        canPress = true;
    }

    private void MusicManager_BeatPassed(object sender, EventArgs e)
    {
        //beat++;
        
    }

    private void Update()
    {
        if (debugText)
            debugText.text = MusicManager.numBeats + ". " + Registry.musicManager.CheckRhythm().ToString();

        firePressed = Input.GetButtonDown(inputController.fireButton);

        if ((!firePressed && canPress && MusicManager.numAvvallamenti >= lastPressedBeat + 1 && lastPressedBeat >= 0)  // Diminuire moltiplicatore di 1
            || firePressed && !canPress) //Reset Contatore moltiplicatore punteggio
        {
            laserWaveRenderer.SetVisible(false);
            laserCollider.enabled = false;
            lastPressedBeat = -1;
           
        }

        if (firePressed && canPress)
        {
            canPress = false;
            lastPressedBeat = GetNearestBeat();
            if (Registry.musicManager.CheckRhythm() != RhythmState.awful)
            {
                laserWave.Fire();
                laserWaveRenderer.SetVisible(true);
                laserCollider.enabled = true;
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
