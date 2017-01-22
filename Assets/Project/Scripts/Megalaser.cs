using UnityEngine;
using System.Collections;

public class Megalaser : MonoBehaviour
{
    private LineRenderer lineRenderer;
    private float height;
    private LaserWaveRenderer laserWaveRenderer;

    private float showTime = 0f;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        laserWaveRenderer = GetComponent<LaserWaveRenderer>();
    }

    public void Show()
    {
        if (showTime <= 0f)
        {
            showTime = 0.5f;
            lineRenderer.enabled = true;
        }
    }

    private void Update()
    {
        if (showTime > 0f)
        {
            showTime -= Time.deltaTime;

            if (showTime <= 0)
            {
                lineRenderer.enabled = false;
            }
        }
    }

    public LineRenderer LineRenderer
    {
        get { return lineRenderer; }
    }

    public float Height
    {
        get { return height; }
        set
        {
            height = value;
            laserWaveRenderer.Height = value;
        }
    }
}
