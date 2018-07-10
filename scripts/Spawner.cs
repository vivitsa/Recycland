using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject bananaPrefab;
	public float secondsBetweenSpawns = 1;
	float nextSpawnTime;

	Vector2 screenHalfSizeWorldUnits;

	// Use this for initialization
	void Start () {
		screenHalfSizeWorldUnits = new Vector2 (Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
	}
	
	// Update is called once per frame
	void Update () {

		if (Time.time > nextSpawnTime) {
			nextSpawnTime = Time.time + secondsBetweenSpawns;
			Vector2 spawnPosition = new Vector2 (Random.Range (-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), screenHalfSizeWorldUnits.y + .5f);
			Instantiate (bananaPrefab, spawnPosition, Quaternion.identity);
			
		}
	
	}
}
