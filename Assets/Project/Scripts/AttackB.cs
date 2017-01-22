using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackB : MonoBehaviour
{
    public Monster monsterBulletB;
    private float timerStart;
    public float timerFire;
    public float timerStopFire;
    private float timerStopFireInt;

    void Start ()
    {
        timerStart = Time.time;
        timerStopFireInt = Time.time + timerStopFire;
    }

    void Update()
    {
        //SPARA
        if (Time.time >= timerStart + timerFire && Time.time <= timerStopFireInt)
        {
            timerStart = Time.time;
            monsterBulletB.Spawn(transform.position + new Vector3(0.5f, 1.5f, 0f));
            GetComponentInChildren<Animator>().SetBool("Attack", true);
            StartCoroutine(ResetAttackAnimation());
        }
    }

    private IEnumerator ResetAttackAnimation()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponentInChildren<Animator>().SetBool("Attack", false);
    }
}
