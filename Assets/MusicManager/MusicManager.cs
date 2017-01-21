using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MusicManager : MonoBehaviour {

	//public float delay;
	//public Text mText, bText;

	public AudioClip introClip, loopSafeClip, loopDangerClip;
	public float bpm;
	public float[] ranges;

	public static int numBeats;

	private float mTime;
	private AudioSource audioSource;
	private float bps;
	private float beatTime;
	private float inverseBeatTime;
	private bool canInstantiate = true;

	Dictionary<GameObject, Vector3> listToInstantiate;

	public event EventHandler BeatPassed;
	
	void Awake()
	{
		Registry.musicManager = this;
		listToInstantiate = new Dictionary<GameObject, Vector3>();
		audioSource = GetComponent<AudioSource>();
		bps = 1/(bpm / 60f);


	}
	
	// Use this for initialization
	void Start () {
		Init();
		CheckToInvoke();
	}
	
	// Update is called once per frame
	void Update () {
		mTime = audioSource.time;
		beatTime = (mTime % bps)/(bps);
		inverseBeatTime = 1 - beatTime;
		beatTime = Mathf.Max(beatTime, inverseBeatTime);
		beatTime = (beatTime - (0.5f))/0.5f;

	}

	private void Init()
	{
		audioSource.clip = introClip;
		audioSource.loop = true;
		audioSource.Play();
	}

	public RhythmState CheckRhythm()
	{
		if(beatTime >= ranges[2] && beatTime <= 1f)
		{
			Debug.Log("Perfect");
			return RhythmState.perfect;
		}

		else if(beatTime >= ranges[1] && beatTime < ranges[2])
		{
			Debug.Log("Good");
			return RhythmState.great;
		}

		else if(beatTime >= ranges[0] && beatTime < ranges[1])
		{
			Debug.Log("OK");
			return RhythmState.ok;
		}
		else
		{
			Debug.Log("Awful");
			return RhythmState.awful;
		}
	}

	public void CheckRhythmFromButton()
	{
		CheckRhythm();
	}

	public void AddToList(GameObject toInstantiate, Vector3 position)
	{
		listToInstantiate.Add(toInstantiate, position);
	}

	private void SpawnList()
	{
		numBeats++;
		OnBeatPassed(new EventArgs());
		Debug.Log(numBeats);

		GameObject instance;
		foreach(KeyValuePair<GameObject, Vector3> toInstantiate in listToInstantiate)
		{
			instance = Instantiate(toInstantiate.Key, toInstantiate.Value, Quaternion.identity);
		}
		listToInstantiate.Clear();


		Invoke("CheckToInvoke", inverseBeatTime*bps + 0.1f);

	}

	private void CheckToInvoke()
	{
		SpawnList();

	}

	protected virtual void OnBeatPassed(EventArgs e)
	{
		EventHandler handler = BeatPassed;
		if (handler != null)
			handler(this, e);
	}
}
