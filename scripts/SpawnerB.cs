using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerB : MonoBehaviour {
public GameObject plasticbottlePrefab;
public float secondsBetweenSpawns = 2;
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
		Vector2 spawnPosition = new Vector2 (Random.Range (-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), screenHalfSizeWorldUnits.y);
		Instantiate (plasticbottlePrefab, spawnPosition, Quaternion.identity);
	}
}
}
	
