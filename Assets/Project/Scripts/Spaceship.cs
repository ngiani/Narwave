using UnityEngine;
using System.Collections;

public class Spaceship : MonoBehaviour
{
    private LaserWave laserWave;
    private LaserWaveRenderer laserWaveRenderer;

    private void Start()
    {
        laserWave = GetComponent<LaserWave>();
        laserWaveRenderer = GetComponent<LaserWaveRenderer>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
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
