using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float timerSpawn;
    public Monster monsterA;
    public Monster monsterB;
    public Monster monsterC;
    public Monster monsterD;
    //public Vector3 spawnPoint;
    private float timerStart;
    private Vector3 spawnPoint1;
    private Vector3 spawnPoint2;
    private Vector3 realSpawnPoint;

    private int wave;
    private float timerStartWave;
    private bool fineGame;

    //DEBUG
    //bool bbb = true;
    //FINE DEBUG

    void Start ()
    {
        timerStart = Time.time;
        Camera camera = Camera.main;
        spawnPoint1 = camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
        spawnPoint2 = camera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f));

        timerStartWave = Time.time;
        wave = 1;
        fineGame = false;
    }
	
	void Update ()
    {
       
            if (wave == 1)
            {
                if (Time.time >= timerStart + timerSpawn)
                {
                    float randomY = Random.Range(spawnPoint2.y, spawnPoint1.y);
                    realSpawnPoint = new Vector3(spawnPoint1.x, randomY, 0f);
                    monsterA.Spawn(realSpawnPoint);

                    timerStart = Time.time;
                }
            }

        


        
        

    }



}
