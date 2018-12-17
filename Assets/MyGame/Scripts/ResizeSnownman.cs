using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeSnownman : MonoBehaviour {

    public bool resize;
    SpriteRenderer spriteRenderer;
    float scaleX, scaleY, scaleZ;
    //public float factor; 

    // Use this for initialization
    void Start () {

        spriteRenderer = GetComponent<SpriteRenderer>();
        scaleX = spriteRenderer.transform.localScale.x;
        scaleY = spriteRenderer.transform.localScale.y;
        scaleZ = 0f;
        resize = true;

    }
	
	// Update is called once per frame
	void Update () {
		if (resize)
        {
           float factor = GameSessionSingleton.instance.CalcPercent()/100;
           spriteRenderer.transform.localScale = new Vector3(scaleX*factor, scaleY*factor, 0f);
           Debug.Log("Faktor "+factor);
            resize = false;
        }
	}
}
