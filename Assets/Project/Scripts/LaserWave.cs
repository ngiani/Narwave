using UnityEngine;
using System.Collections;

public class LaserWave : MonoBehaviour
{
    [SerializeField] private float waveHeight = 1;

    private LaserWaveRenderer laserWaveRenderer;
    private Megalaser megalaser;

    private void Start()
    {
        laserWaveRenderer = GetComponent<LaserWaveRenderer>();
        megalaser = GameObject.FindGameObjectWithTag("Megalaser").GetComponent<Megalaser>();

        if (megalaser.LineRenderer && megalaser.LineRenderer.enabled)
            megalaser.LineRenderer.enabled = false;
    }

    public void Fire()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position, waveHeight / 2, transform.right, out hit, 100f, 
            LayerMask.GetMask("PlayerLasers")))
        {
            laserWaveRenderer.Length = Vector3.Distance(transform.position, hit.point);
            megalaser.transform.position = hit.point;
            megalaser.Show();

            megalaser.Height = waveHeight + hit.collider.GetComponent<LaserWave>().WaveHeight;
            
        }
        else
        {
            if (laserWaveRenderer.Length < 50f)
                laserWaveRenderer.Length = 50f;
        }
    }

    public float WaveHeight
    {
        get { return waveHeight; }
        set
        {
            waveHeight = value;
            if (laserWaveRenderer)
                laserWaveRenderer.Height = waveHeight;
        }
    }

    private void OnValidate()
    {
        WaveHeight = waveHeight;
    }
}
