using UnityEngine;
using System.Collections;

public class LaserWave : MonoBehaviour
{
    [SerializeField] private float waveHeight = 1;

    private LaserWaveRenderer laserWaveRenderer;
    private LaserWaveRenderer megalaser;

    private void Start()
    {
        laserWaveRenderer = GetComponent<LaserWaveRenderer>();
        megalaser = GameObject.FindGameObjectWithTag("Megalaser").GetComponent<LaserWaveRenderer>();

        if (megalaser.LineRenderer && megalaser.LineRenderer.enabled)
            megalaser.LineRenderer.enabled = false;
    }

    public void Fire()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position, waveHeight / 2, transform.right, out hit, 100f, 
            LayerMask.GetMask("PlayerLasers", "Enemies")))
        {
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("PlayerLasers"))
            {
                laserWaveRenderer.Length = Vector3.Distance(transform.position, hit.point) / 2;
                megalaser.transform.position = hit.point;
                if (!megalaser.LineRenderer.enabled)
                {
                    megalaser.LineRenderer.enabled = true;
                }

                megalaser.Height = waveHeight + hit.collider.GetComponent<LaserWave>().WaveHeight;
            }
            //else if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Enemies"))
           


            
        }
        else
        {
            if (laserWaveRenderer.Length < 10f)
                laserWaveRenderer.Length = 10f;
            if (megalaser.LineRenderer.enabled)
                megalaser.enabled = false;
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
