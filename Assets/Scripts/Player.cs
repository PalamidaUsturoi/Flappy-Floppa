using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Player : MonoBehaviour {
    public Action OnCollision;
    private Rigidbody2D rigidBody;
    public int speedUp = 5;

    private void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    public void Jump() {
        rigidBody.velocity = new Vector3(0, speedUp, 0);
    }

    private void Fall() {
        rigidBody.velocity = new Vector3(0, -2, 0);
    }

    private void OnCollisionEnter2D(Collision2D col) {
        if ( OnCollision != null )
            OnCollision.Invoke();
    }
}
