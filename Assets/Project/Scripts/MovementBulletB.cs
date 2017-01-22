using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBulletB : MonoBehaviour
{
    public float speed;
    Vector3 pos;
    Vector3 translation;

    void OnEnable()
    {
        string target;
        float rnd = Random.Range(0f, 1.0f);
        if (rnd <= 0.5f)
        {
            target = "Narvalo";
        }
        else
        {
            target = "Foca";
        }
        pos = GameObject.Find(target).transform.position;
        translation = (pos - transform.position).normalized;
    }

    void Update()
    {
        //MOVIMENTO
        gameObject.transform.Translate(translation * speed * Time.deltaTime);
    }
}
