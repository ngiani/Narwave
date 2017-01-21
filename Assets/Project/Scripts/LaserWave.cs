using UnityEngine;
using System.Collections;

public class LaserWave : MonoBehaviour
{
    public float waveHeight = 1;

    private LaserWaveRenderer laserWaveRenderer;

    private void Start()
    {
        laserWaveRenderer = GetComponent<LaserWaveRenderer>();
    }

    public void Fire()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position, waveHeight / 2, transform.right, out hit))
        {
            laserWaveRenderer.Length = Vector3.Distance(transform.position, hit.point) / 2;
            Debug.Log("transform.position: " + transform.position + "; hit.point: " + hit.point + "; distance: " + laserWaveRenderer.Length);
        }
        else if (laserWaveRenderer.Length < 10f)
        {
            //laserWaveRenderer.Length = 10f;
        }
    }
}
