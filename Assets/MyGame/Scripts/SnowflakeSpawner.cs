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
    public int snowflakeMinSize = 3;
    public int snowflakeMaxSize = 7;

    public float snowflakeGravityMin = 0.1f;
    public float snowflakeGravityMax = 0.8f;

    public int yPos = 450;

    private SpriteRenderer spriteRenderer;

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


        Snowflake clone = (Snowflake)Instantiate(snowflakePrefab, transform.position, transform.rotation);
        
        clone.GetComponent<SpriteRenderer>().sortingOrder = Random.Range(2,8);
        if (clone.GetComponent<SpriteRenderer>().sortingOrder == 7)
        {
            clone.GetComponent<SpriteRenderer>().color = Color.blue;
        }
        clone.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2,2), Random.Range(-10,-1));
    }
}
