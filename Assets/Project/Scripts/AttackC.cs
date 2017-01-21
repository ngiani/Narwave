using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackC : MonoBehaviour
{
    public Monster monsterBulletC;
    public int bulletCount;
    private Monster bulletTmp;
    private float timerStart;
    public float timerFire;
    public float timerStopFire;
    private float timerStopFireInt;

    void Start()
    {
        timerStart = Time.time;
        timerStopFireInt = Time.time + timerStopFire;
    }

    void Update()
    {
        
        //SPARA
        if (Time.time >= timerStart + timerFire && Time.time <= timerStopFireInt)
        {
            this.Attack();
            timerStart = Time.time;
        }
        
        
    }

    public void Attack ()
    {
        for (int i=0; i<bulletCount; i++)
        {
            bulletTmp = monsterBulletC.Spawn(transform.position);

            if (i == 0)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.up);
            else if (i == 1)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.down);
            else if (i == 2)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.left);
            else if (i == 3)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.right);
            else if (i == 4)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.right + Vector3.down);
            else if (i == 5)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.right + Vector3.up);
            else if (i == 6)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.left + Vector3.down);
            else if (i == 7)
                bulletTmp.gameObject.GetComponent<MovementBulletC>().setTranslation(Vector3.left + Vector3.up);
        }

        
        /*
        monsterBulletC.Spawn(new Vector3(0f, 1.0f, 0f)); // UP
        monsterBulletC.Spawn(new Vector3(0f, -1.0f, 0f)); // DOWN
        monsterBulletC.Spawn(new Vector3(-1.0f, 0f, 0f)); // LEFT
        monsterBulletC.Spawn(new Vector3(1.0f, 0f, 0f)); // RIGHT
        monsterBulletC.Spawn(new Vector3(1.0f, 1.0f, 0f));
        */
    }

}
