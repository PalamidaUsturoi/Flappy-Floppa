using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour {
    public Action<Collision2D> OnCollision;
    private Rigidbody2D rigidBody;
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
}
