using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBulletD : MonoBehaviour
{
    public float speed;
    //Vector3 pos;
    Vector3 translation;

    void OnEnable()
    {
        translation = new Vector3(0f, 0f, 0f);
    }

    void Update()
    {
        //MOVIMENTO
        Vector2 translation = Vector2.down;
        gameObject.transform.Translate(translation * speed * Time.deltaTime);
    }
}