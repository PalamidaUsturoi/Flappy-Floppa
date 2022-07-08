using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour {
    public Action<Collision2D> OnCollision;
    private Rigidbody2D rigidBody;
    public Sprite Birb1;
    public Sprite Birb2;
    public Sprite Birb3;
    public float count;
    public int speedUp = 5;

    private void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void Jump() {
        rigidBody.velocity = new Vector3(0, speedUp, 0);
    }

    public void Stop() {
        speedUp = 0;
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }

    private void OnCollisionEnter2D(Collision2D col) {
        // Debug.Log(col.collider.name);
        if ( OnCollision != null )
            OnCollision.Invoke(col);
    }
    private void Update()
    {
        count += Time.deltaTime*6;
        count %= 3;
        if(count > 0 && count < 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Birb1;
        }
        else
        {
            if(count >= 1 && count <2)
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Birb2;
            }
            else
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Birb3;
            }
        }

    }
}
