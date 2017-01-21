using UnityEngine;
using System.Collections;

[RequireComponent(typeof(LineRenderer))]
public class LaserWaveRenderer : MonoBehaviour
{
    [SerializeField] private float height = 1;
    [SerializeField] private float length = 10f;
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
        Length = length;
        Height = height;
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

    private void OnValidate()
    {
        if (lineRenderer)
        {
            Length = length;
            Height = height;
        }
    }

    /// <summary>
    /// The length of the rendered wave in meters.
    /// </summary>
    public float Length
    {
        get { return length; }
        set
        {
            length = value;
            lineRenderer.SetPosition(1, new Vector3(length, 0f, 0f));
        }
    }

    /// <summary>
    /// The height of the rendered wave in meters.
    /// </summary>
    public float Height
    {
        get { return height; }
        set
        {
            height = value;
            lineRenderer.widthMultiplier = height;
        }
    }
}
