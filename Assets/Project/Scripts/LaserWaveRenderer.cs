using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]
public class LaserWaveRenderer : MonoBehaviour
{
    /// <summary>
    /// The number of complete texture offsets done in 1 second.
    /// </summary>
    public float moveFrequency = 10f;

    private float currentTextureOffset = 0f;

    private LineRenderer lineRenderer;
    private Material material;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        material = lineRenderer.material;
    }

    private void Update()
    {
        if (!lineRenderer.enabled)
            return;

        currentTextureOffset = (currentTextureOffset - moveFrequency * Time.deltaTime) % 1f;
        material.mainTextureOffset = new Vector2(currentTextureOffset, 0f);
    }

    public void SetVisible(bool value)
    {
        if (lineRenderer.enabled != value)
            lineRenderer.enabled = value;
    }
}
