using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackB : MonoBehaviour
{
    public Monster monsterBulletB;
    private float timerStart;
    public float timerFire;
    public float timerStopFire;

    void Start ()
    {
        timerStart = Time.time;
    }

    void Update()
    {
        //SPARA
        if (Time.time >= timerStart + timerFire && Time.time <= timerStopFire)
        {
            monsterBulletB.Spawn(transform.position + new Vector3(0.5f, 1.5f, 0f));
            timerStart = Time.time;
        }
    }
}
