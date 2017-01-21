using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]
public class LaserWave : MonoBehaviour
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
        currentTextureOffset = (currentTextureOffset - moveFrequency * Time.deltaTime) % 1f;
        material.mainTextureOffset = new Vector2(currentTextureOffset, 0f);
    }
}
