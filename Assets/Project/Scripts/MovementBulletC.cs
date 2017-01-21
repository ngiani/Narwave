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
        translation = new Vector3(0f, 0f, 0f);
    }

    void Update()
    {
        //MOVIMENTO
        gameObject.transform.Translate(translation * speed * Time.deltaTime);
    }

    public void setTranslation (Vector3 v)
    {
        translation = v;
    }
}