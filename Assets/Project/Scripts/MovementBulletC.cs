using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBulletC : MonoBehaviour
{
    public float speed;
    Vector3 pos;
    Vector3 translation;

    void Start()
    {
        pos = GameObject.Find("Spaceship").transform.position;
        translation = (pos - transform.position).normalized;
    }

    void Update()
    {
        //MOVIMENTO
        gameObject.transform.Translate(translation * speed * Time.deltaTime);
    }
}