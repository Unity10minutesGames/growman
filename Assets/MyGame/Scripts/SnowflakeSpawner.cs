using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowflakeSpawner : MonoBehaviour {

    public Snowflake snowflakePrefab;
    private bool spawn = true;

    public float minSpawnDelay = 1f;
    public float maxSpawnDelay = 5f;

    public int xMinLeft = -5;
    public int xMaxLeft = 5;
    public int snowflakeMinSize = 4;
    public int snowflakeMaxSize = 10;

    public float snowflakeGravityMin = 0.1f;
    public float snowflakeGravityMax = 0.8f;

    public int yPos = 450;

    // Use this for initialization
    IEnumerator Start () {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnSnowflake();
        }

	}

    private void SpawnSnowflake()
    {
        transform.position = new Vector3(Random.Range(xMinLeft, xMaxLeft), yPos, 0);
        float snowflakeSize = Random.Range(snowflakeMinSize, snowflakeMaxSize);
        snowflakePrefab.GetComponent<Transform>().localScale= new Vector3(snowflakeSize, snowflakeSize, 0);
        Instantiate(snowflakePrefab, transform.position, transform.rotation);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
