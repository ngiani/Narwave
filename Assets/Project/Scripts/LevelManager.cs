using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Monster monsterA;
    public Monster monsterB;
    public Monster monsterC;
    public Monster monsterD;
    private Vector3 spawnPoint1;
    private Vector3 spawnPoint2;
    private Vector3 realSpawnPoint;
    //public Vector3 spawnPoint;

    private float timerStart;
    private float timerStartA;
    private float timerStartB;
    private float timerStartC;
    private float timerStartD;
    public float timerSpawn;
    private float timerSpawnA;
    private float timerSpawnB;
    private float timerSpawnC;
    private float timerSpawnD;
    public float timerDelayBetweenWaves;
    private float timerWave;
    //private int wave;
    //private bool fineGame;

    //DEBUG
    //bool bbb = true;
    //FINE DEBUG

    void Start ()
    {
        timerStart = Time.time;
        timerStartA = timerStart;
        timerStartB = timerStart;
        timerStartC = timerStart;
        timerStartD = timerStart;
        timerWave = timerStart + timerDelayBetweenWaves;
        timerSpawnA = timerSpawn;
        timerSpawnB = timerSpawn*3;
        timerSpawnC = timerSpawn*3;
        timerSpawnD = timerSpawn*3;
        Camera camera = Camera.main;
        spawnPoint1 = camera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0f));
        spawnPoint2 = camera.ScreenToWorldPoint(new Vector3(Screen.width, 0f, 0f));

        //timerStartWave = Time.time;
        //wave = 1;
        //fineGame = false;
    }
	
	void Update ()
    {
        // SPAWNA MOSTRI A
        if (Time.time >= timerStartA + timerSpawnA)
        {
            float randomY = Random.Range(spawnPoint2.y, spawnPoint1.y);
            realSpawnPoint = new Vector3(spawnPoint1.x, randomY, 0f);
            monsterA.Spawn(realSpawnPoint);

            timerStartA = Time.time;
        }

        // SPAWNA MOSTRI B
        if (Time.time >= timerStartB + timerSpawnB && Time.time >= timerWave)
        {
            float randomY = Random.Range(spawnPoint2.y, spawnPoint1.y);
            realSpawnPoint = new Vector3(spawnPoint1.x, randomY, 0f);
            monsterB.Spawn(realSpawnPoint);

            timerStartB = Time.time;
        }

        // SPAWNA MOSTRI C
        if (Time.time >= timerStartC + timerSpawnC && Time.time >= timerWave*2)
        {
            float randomY = Random.Range(spawnPoint2.y, spawnPoint1.y);
            realSpawnPoint = new Vector3(spawnPoint1.x, randomY, 0f);
            monsterC.Spawn(realSpawnPoint);

            timerStartC = Time.time;
        }

        // SPAWNA MOSTRI D
        if (Time.time >= timerStartD + timerSpawnD && Time.time >= timerWave*3)
        {
            float randomY = Random.Range(spawnPoint2.y, spawnPoint1.y);
            realSpawnPoint = new Vector3(spawnPoint1.x, randomY, 0f);
            monsterD.Spawn(realSpawnPoint);

            timerStartD = Time.time;
        }






    }



}
