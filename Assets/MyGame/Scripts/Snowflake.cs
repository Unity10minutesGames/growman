using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowflake : MonoBehaviour {
    private const string TAGCOLLIDER = "Collider";
    private const string TAGPLAYER = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == TAGCOLLIDER)
        {
            if (gameObject.GetComponent<SpriteRenderer>().sortingOrder == 7)
            {
                GameSessionSingleton.instance.addMissedSnowflake();
            }
               
            Destroy(gameObject);
        }

        else if (collision.tag == TAGPLAYER)
        {
            if (gameObject.GetComponent<SpriteRenderer>().sortingOrder == 7) {
                GameSessionSingleton.instance.addCollectedSnowflake();
                Destroy(gameObject);
            }
        }
    }
}
