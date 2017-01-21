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
        if (true)//if (Input.GetKey(KeyCode.Space))
        {
            laserWave.Fire();
            laserWaveRenderer.SetVisible(true);
        }
        else
        {
            laserWaveRenderer.SetVisible(false);
        }
    }
}
