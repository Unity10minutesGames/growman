using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private const string AXISHORIZONTAL = "Horizontal";
    private const string AXISVERTICAL   = "Vertical";

    SpriteRenderer spriteRenderer;
    EdgeCollider2D edgeCollider;
    private float xMin, xMax, deltaXold;


    public float moveSpeed = 5.0f;
    public float padding = 0.5f;

	// Use this for initialization
	void Start () {
        SetupMoveBounderies();
        spriteRenderer = GetComponent<SpriteRenderer>();
        edgeCollider = GetComponent<EdgeCollider2D>();
        deltaXold = 0.0f;
        
	}

    private void SetupMoveBounderies()
    {
        Camera gameCamera = Camera.main;
        xMin = gameCamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x + padding;
        xMax = gameCamera.ViewportToWorldPoint(new Vector3(1f, 0f, 0f)).x - padding;
    }
	
	// Update is called once per frame
	void Update () {

        bool flip = false; 

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            flip = true;
            Debug.Log("flip: " + flip);
        }

        Move(flip);

        
    }

    private void Move(bool flip)
    {
        var deltaX = Input.GetAxis(AXISHORIZONTAL) * Time.deltaTime * moveSpeed;
        var newPosX = Mathf.Clamp(transform.position.x + deltaX, xMin, xMax);

        if (flip)
        {
            FlipPlayer2(deltaX);
        }
        
        transform.position = new Vector2(newPosX, transform.position.y);
    }

    private void FlipPlayer(float deltaX)
    {
        if ((deltaXold <= 0) && (deltaX > 0))
        {
            spriteRenderer.flipX = true;
            edgeCollider.offset = new Vector2(-3.2f,0f);
        }
        if ((deltaXold >= 0) && (deltaX < 0))
        {
            spriteRenderer.flipX = false;
            edgeCollider.offset = new Vector2(0f, 0f);
        }

        deltaXold = deltaX;
    }

    private void FlipPlayer2(float deltaX)
    {
        if (spriteRenderer.flipX)
        {
            spriteRenderer.flipX = false;
            edgeCollider.offset = new Vector2(0f, 0f);
        }
        else
        {
            spriteRenderer.flipX = true;
            edgeCollider.offset = new Vector2(-3.2f, 0f);
        }
        Debug.Log("in flip player 2");
        
        
    }

}
