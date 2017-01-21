using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementB : MonoBehaviour
{
    public float speed;
    private float timerStart;
    public float timerStop; //dopo quanti secondi si ferma
    public float timerGo; //dopo quanti secondi, dopo essersi fermato, riparte

    void Start()
    {
        timerStart = Time.time;
    }

    void Update()
    {
        //MOVIMENTO ORIZZONTALE
        if ( (Time.time < timerStart + timerStop) || (Time.time > timerStart + timerStop + timerGo))
        {
            Vector2 translation = Vector2.left;
            gameObject.transform.Translate(translation * speed * Time.deltaTime);
        }
        //MOVIMENTO VERTICALE
        else
        {
            Vector3 pos = GameObject.Find("Spaceship").transform.position;
            Vector2 translation = Vector2.up;
            if (this.transform.position.y <= pos.y)
            {
                translation = Vector2.up;
            }
            else
            {
                translation = Vector2.down;
            }
            gameObject.transform.Translate(translation * speed * Time.deltaTime);
        }


        
    }
}
