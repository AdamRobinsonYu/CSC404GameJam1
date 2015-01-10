using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BirdSpawner : MonoBehaviour {
	
	public GameObject birdPrefab;
	public List<GameObject> spawnPoints;
	public int timeoutPeriod = 1;

	float timer;

	// Use this for initialization
	void Start () {
		this.timer = this.timeoutPeriod;
	}
	
	// Update is called once per frame
	void Update () {
		this.timer -= Time.deltaTime;
		if (this.timer <= 0) {
			this.timer = this.timeoutPeriod;
			GameObject newBird = (GameObject)GameObject.Instantiate(birdPrefab);
			newBird.transform.position = this.spawnPoints[Random.Range(0, this.spawnPoints.Count)].transform.position;
		}
	}
}
