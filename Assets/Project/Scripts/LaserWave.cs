using UnityEngine;
using System.Collections;

public class LaserWave : MonoBehaviour
{
    public float waveHeight = 1;

    public void Fire()
    {
        RaycastHit hit;
        Physics.SphereCast(transform.position, waveHeight / 2, transform.right, out hit);

    }
}
